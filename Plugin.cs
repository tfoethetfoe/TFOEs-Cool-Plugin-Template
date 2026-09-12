using System;
using System.Collections.Generic;
using BepInEx;
using Seralyth.Classes;
using Seralyth.Classes.Menu;
using Seralyth.Menu;
using Seralyth.Mods;
using TFOEsCoolPlugin.Mods;
using UnityEngine;
using WebSocketSharp;
using static Seralyth.Menu.Main;

namespace TFOEsCoolPlugin
{
    // NOTICE FROM TFOE
    // Any use of this template to make a plugin that exploits our console system is not permitted
    // Punishment for breaking this rule is a blacklist from using TFOE's Cool Menu and a ban from the discord.
    public class Plugin
    {
        public static string CategoryName = "Plugin Mods";
        public static string Name = "Example Plugin";
        public static string Description = "An example plugin used for testing.";
        public struct ModData
        {
            public string Name;
            public string Description;
            public Action Method;
        }
        public static SortedDictionary<int, ModData> SortedMods = new SortedDictionary<int, ModData>();
        
        public static void AddSortedMods()
        {
            SortedMods.Clear();

            
            SortedMods.Add(1, new ModData
            {
                Name = "Test Inputs",
                Description = "Sends a notification telling you what input you pressed.",
                Method = () => { PluginMods.testinputs(); }
            });
        }
        public static void OnEnable()
        {
            int category = Buttons.AddCategory(CategoryName);
            Buttons.AddButton(Buttons.GetCategory("Main"), new ButtonInfo { buttonText = CategoryName, method = () =>  Buttons.CurrentCategoryName = CategoryName , isTogglable = false, toolTip = "Opens the plugin mods tab.", legal = true });
            Buttons.AddButton(Buttons.GetCategory(CategoryName), new ButtonInfo { buttonText = "Exit " + CategoryName, method = () => Buttons.CurrentCategoryName = "Main", isTogglable = false, toolTip = "Exits the plugin mods tab.", legal = true });
            AddSortedMods();
            AddButtons();
        }

        // This runs when the plugin stops, or when plugins are reloaded
        // You should put all of your removing of buttons / categories here
        public static void OnDisable()
        {
            UnityEngine.Debug.Log("Plugin " + Name + " has been disabled!");

            Buttons.RemoveCategory(CategoryName);
            Buttons.RemoveButton(Buttons.GetCategory("Main"), CategoryName);
        }
        
        // This runs every frame before the mods
        public static void Update()
        {
            // UnityEngine.Debug.Log(Time.time);
        }

        // This runs when the menu UI is open (togglable with backslash)
        // I don't recommend using this as an update method
        public static void OnGUI()
        {
            // GUI.Button(new Rect(10, 10, 200, 100), "Test Button");
        }
        
        public static List<int> ModMethod = new List<int>()
        {
            1,
            2
        };
        public static void AddButtons()
        {
            // Loops through the mods perfectly in 1, 2, 3... order without duplicating buttons
            foreach (KeyValuePair<int, ModData> kvp in SortedMods)
            {
                ModData mod = kvp.Value;

                Buttons.AddButton(Buttons.GetCategory(CategoryName), new ButtonInfo
                {
                    buttonText = mod.Name,
                    method = mod.Method,
                    isTogglable = true,
                    toolTip = mod.Description
                });
            }
        }



    }
}
