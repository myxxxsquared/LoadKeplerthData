using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

using ProtoBuf;
using System.Text.RegularExpressions;

namespace LoadKeplerthData
{
    public class Program
    {
        private static List<Tuple<Regex, Type>> types;

        private static void addType(String regex, Type type)
        {
            types.Add(new Tuple<Regex, Type>(new Regex('^' + regex + '$'), type));
        }
        private static void initTypes()
        {
            types = new List<Tuple<Regex, Type>>();
            // Map Map/\\d+/
            addType("mapData\\.dat", typeof(WorldState));
            addType("hotData\\.dat", typeof(Dictionary<ulong, ulong>));
            addType("itemsData\\.dat", typeof(ItemsDatas));
            addType("achievementData\\.dat", typeof(Dictionary<KeyValuePair<int, long>, ulong>));
            addType("dungeonData\\.dat", typeof(List<DungeonData>));
            addType("defence_dungeonData\\.dat", typeof(List<DefenceDungeon>));
            addType("intruderData\\.dat", typeof(Dictionary<string, IntruderData>));
            addType("unlock_intruderData\\.dat", typeof(Dictionary<int, long>));
            addType("pos_intruderData\\.dat", typeof(List<string>));
            addType("NpcManagerData\\.dat", typeof(NpcManagerData));
            addType("NpcPlacementData\\.dat", typeof(List<NpcPlacementData>));

            // Character Character/\\d+/
            addType("playerSpaceDropItemsData\\.dat", typeof(Dictionary<int, ItemData>));
            addType("achievementData\\.dat", typeof(Dictionary<KeyValuePair<int, long>, ulong>));
            addType("spacePortalData\\.dat", typeof(Dictionary<int, PortalData>));
            addType("mercenaryManagerData\\.dat", typeof(MercenaryManagerData));
            addType("buffData\\.dat", typeof(List<Buff>));
            addType("DNACardsData\\.dat", typeof(DNAManager));
            addType("characterData\\.dat", typeof(CharacterState));
            addType("playerData\\.dat", typeof(PlayerState));

            // Multiplayer Character/\\d+/\\d+/
            addType("privateDungeonData\\.dat", typeof(List<DungeonData>));
            addType("dungeonChestData\\.dat", typeof(List<string>));

            // Global Global/
            addType("achievementData\\.dat", typeof(Dictionary<KeyValuePair<int, long>, ulong>));
            addType("worldClueData\\.dat", typeof(Dictionary<int, bool>));
            addType("achievementData2\\.dat", typeof(Dictionary<int, bool>));
            addType("keybindingData\\.dat", typeof(Dictionary<KeyBindingType, KeyBindingData>));
            addType("activeModsList\\.dat", typeof(ActiveMods));

            // Map or Multiplayer
            addType("waypoint", typeof(WaypointData));
            addType("markpoint", typeof(Dictionary<int, PointMarkData>));
            addType("miniMapPet", typeof(Dictionary<int, MiniMapPetData>));
            addType("miniMapCreature", typeof(Dictionary<int, MiniMapCreatureData>));
            addType("miniMapVilliage", typeof(List<MapVilliageData>));
            addType("miniMapNpcClue", typeof(List<NpcClueData>));
            addType("miniMapPlacement", typeof(Dictionary<string, MiniMapPlacementData>));
            addType("dropItemsData\\.dat", typeof(Dictionary<int, ItemData>));
            addType("mapPetData\\.dat", typeof(Dictionary<int, MapPetData>));
            addType("portalData\\.dat", typeof(Dictionary<int, PortalData>));

            // Map data
            addType("-?(\\d+)--?(\\d+)(\\.-?(\\d+))?\\.dat", typeof(StructureArea));

            addType("temp\\.dat", null);
            addType(".+\\.png", null);
            addType(".+\\.vdf", null);
            addType(".+\\.log", null);
            addType("config", null);
            addType("values", null);
        }

        private static void processFolder(DirectoryInfo dir, List<FileInfo> list)
        {
            foreach (FileInfo file in dir.EnumerateFiles())
            {
                list.Add(file);
            }
            foreach (DirectoryInfo subDir in dir.EnumerateDirectories())
            {
                processFolder(subDir, list);
            }
        }

        private static List<FileInfo> allFiles()
        {
            List<FileInfo> files = new List<FileInfo>();
            DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Users\\moesa\\Desktop\\x");
            processFolder(directoryInfo, files);

            return files;
        }

        public static void Main(string[] args)
        {
            JsonConverter[] converters = new JsonConverter[] { new KeyValuePairConvertor() };
            initTypes();

            bool direction = false;

            foreach (FileInfo info in allFiles())
            {
                string fileName = info.Name;
                string fileNameToMatch;
                if (fileName.EndsWith(".json"))
                {
                    if (direction)
                        continue;
                    string fileNameStrip = fileName.Substring(0, fileName.Length - 5);
                    if (fileNameStrip.EndsWith("2"))
                    {
                        fileNameToMatch = fileNameStrip.Substring(0, fileNameStrip.Length - 1);
                    }
                    else
                    {
                        fileNameToMatch = fileNameStrip;
                    }
                    bool found = false;
                    Type type = null;
                    foreach (Tuple<Regex, Type> tuple in types)
                    {
                        if (tuple.Item1.IsMatch(fileNameToMatch))
                        {
                            found = true;
                            type = tuple.Item2;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Failed to find processor for {0}.", info.FullName);
                    }
                    if (type == null)
                    {
                        continue;
                    }

                    Console.WriteLine(info.FullName);

                    try
                    {
                        string json = File.ReadAllText(info.FullName);
                        Object obj = JsonConvert.DeserializeObject(json, type, converters);
                        using (FileStream stream = new FileStream(info.FullName.Substring(0, info.FullName.Length - 5), FileMode.Truncate | FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            Serializer.NonGeneric.Serialize(stream, obj);
                        }

                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("Failed to process file: {0}.", info.FullName);
                        Console.WriteLine(exception.ToString());
                    }
                }
                else
                {
                    if (!direction)
                        continue;
                    if (fileName.EndsWith("2"))
                    {
                        fileNameToMatch = fileName.Substring(0, fileName.Length - 1);
                    }
                    else
                    {
                        fileNameToMatch = fileName;
                    }
                    bool found = false;
                    Type type = null;
                    foreach (Tuple<Regex, Type> tuple in types)
                    {
                        if (tuple.Item1.IsMatch(fileNameToMatch))
                        {
                            found = true;
                            type = tuple.Item2;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Failed to find processor for {0}.", info.FullName);
                    }
                    if (type == null)
                    {
                        continue;
                    }

                    Console.WriteLine(info.FullName);

                    try
                    {
                        object obj;
                        using (FileStream stream = info.OpenRead())
                        {
                            obj = Serializer.NonGeneric.Deserialize(type, stream);
                        }
                        string output = JsonConvert.SerializeObject(obj, Formatting.Indented, converters);

                        try
                        {
                            JsonConvert.DeserializeObject(output, type, converters);
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine("Failed to deserialize file: {0}.", info.FullName);
                            Console.WriteLine(exception.ToString());
                        }

                        File.WriteAllText(info.FullName + ".json", output);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("Failed to process file: {0}.", info.FullName);
                        Console.WriteLine(exception.ToString());
                    }
                }
            }

            Console.WriteLine("Done. Press any key to exit. . .");
            Console.ReadKey();
        }
    }
}
