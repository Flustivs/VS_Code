using OOP_Test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test.Controller
{
    /// <summary>
    /// This class calls the gui and model depending on what the gui have of input
    /// </summary>
    internal class Controller
    {
        // Variables
        GUI.UserInput user = new GUI.UserInput();
        GUI.Output output = new GUI.Output();
        Model.FiveRoom fiveRoom;
        Model.FourRoom fourRoom;
        Model.ThreeRoom threeRoom;
        Model.TwoRoom twoRoom;
        Model.OneRoom oneRoom;
        // This method has a switch to diferentiate between rooms and so on
        internal void TotalRooms()
        {
            user.Instructions();
            string rooms = user.HowManyRooms();
            string window = user.WhatWindows();
            string floor = user.Floor();
            short squareMeterFloor = short.Parse(floor);
            short windowNumber;
            switch (rooms)
            {
                case "1":
                    switch (window)
                    {
                        case "1":
                            window = "1879";
                            windowNumber = short.Parse(window);
                            oneRoom = new OneRoom(rooms, windowNumber, squareMeterFloor);
                            output.OneRoom(windowNumber, 37899, squareMeterFloor);

                            break;
                        case "2":
                            window = "2798";
                            windowNumber = short.Parse(window);
                            oneRoom = new OneRoom(rooms, windowNumber, squareMeterFloor);
                            output.OneRoom(windowNumber, 37899, squareMeterFloor);
                            break;
                        case "3":
                            window = "4678";
                            windowNumber = short.Parse(window);
                            oneRoom = new OneRoom(rooms, windowNumber, squareMeterFloor);
                            output.OneRoom(windowNumber, 37899, squareMeterFloor);
                            break;
                        case "4":
                            window = "6456";
                            windowNumber = short.Parse(window);
                            oneRoom = new OneRoom(rooms, windowNumber, squareMeterFloor);
                            output.OneRoom(windowNumber, 37899, squareMeterFloor);
                            break;
                        case "5":
                            window = "4879";
                            windowNumber = short.Parse(window);
                            oneRoom = new OneRoom(rooms, windowNumber, squareMeterFloor);
                            output.OneRoom(windowNumber, 37899, squareMeterFloor);
                            break;
                        case "10":
                            window = $"{1879 * 1.30}";
                            windowNumber = short.Parse(window);
                            oneRoom = new OneRoom(rooms, windowNumber, squareMeterFloor);
                            output.OneRoom(windowNumber, 37899, squareMeterFloor);
                            break;
                    }
                    break;
                case "2":
                    double kitchen = double.Parse(rooms);
                    kitchen = 37899 * 1.17;
                    switch (window)
                    {
                        case "1":
                            window = "1879";
                            windowNumber = short.Parse(window);
                            twoRoom = new TwoRoom(rooms, windowNumber, squareMeterFloor);
                            output.TwoRoom(windowNumber, kitchen, squareMeterFloor);

                            break;
                        case "2":
                            window = "2798";
                            windowNumber = short.Parse(window);
                            twoRoom = new TwoRoom(rooms, windowNumber, squareMeterFloor);
                            output.TwoRoom(windowNumber, kitchen, squareMeterFloor);
                            break;
                        case "3":
                            window = "4678";
                            windowNumber = short.Parse(window);
                            twoRoom = new TwoRoom(rooms, windowNumber, squareMeterFloor);
                            output.TwoRoom(windowNumber, kitchen, squareMeterFloor);
                            break;
                        case "4":
                            window = "6456";
                            windowNumber = short.Parse(window);
                            twoRoom = new TwoRoom(rooms, windowNumber, squareMeterFloor);
                            output.TwoRoom(windowNumber, kitchen, squareMeterFloor);
                            break;
                        case "5":
                            window = "4879";
                            windowNumber = short.Parse(window);
                            twoRoom = new TwoRoom(rooms, windowNumber, squareMeterFloor);
                            output.TwoRoom(windowNumber, kitchen, squareMeterFloor);
                            break;
                        case "10":
                            window = $"{1879 * 1.30}";
                            windowNumber = short.Parse(window);
                            twoRoom = new TwoRoom(rooms, windowNumber, squareMeterFloor);
                            output.TwoRoom(windowNumber, kitchen, squareMeterFloor);
                            break;
                    }
                    break;
                case "3":
                    kitchen = double.Parse(rooms);
                    double room = kitchen * 1.17;
                    kitchen = 37899 * room;
                    switch (window)
                    {
                        case "1":
                            window = "1879";
                            windowNumber = short.Parse(window);
                            threeRoom = new ThreeRoom(rooms, windowNumber, squareMeterFloor);
                            output.ThreeRoom(windowNumber, kitchen, squareMeterFloor);

                            break;
                        case "2":
                            window = "2798";
                            windowNumber = short.Parse(window);
                            threeRoom = new ThreeRoom(rooms, windowNumber, squareMeterFloor);
                            output.ThreeRoom(windowNumber, kitchen, squareMeterFloor);
                            break;
                        case "3":
                            window = "4678";
                            windowNumber = short.Parse(window);
                            threeRoom = new ThreeRoom(rooms, windowNumber, squareMeterFloor);
                            output.ThreeRoom(windowNumber, kitchen, squareMeterFloor);
                            break;
                        case "4":
                            window = "6456";
                            windowNumber = short.Parse(window);
                            threeRoom = new ThreeRoom(rooms, windowNumber, squareMeterFloor);
                            output.ThreeRoom(windowNumber, kitchen, squareMeterFloor);
                            break;
                        case "5":
                            window = "4879";
                            windowNumber = short.Parse(window);
                            threeRoom = new ThreeRoom(rooms, windowNumber, squareMeterFloor);
                            output.ThreeRoom(windowNumber, kitchen, squareMeterFloor);
                            break;
                        case "10":
                            window = $"{1879 * 1.30}";
                            windowNumber = short.Parse(window);
                            threeRoom = new ThreeRoom(rooms, windowNumber, squareMeterFloor);
                            output.ThreeRoom(windowNumber, kitchen, squareMeterFloor);
                            break;
                    }
                    break;
                case "4":

                    break;
                case "5":

                    break;
            }

        }
        /*
        internal string TotalCostRooms()
        {
            string s = "";
            return s;
        }
        internal string TotalCostWindows()
        {
            string s = "";
            return s;
        }
        internal string TotalCostFloors()
        {
            string s = "";
            return s;
        }
        internal string TotalKitchenCost()
        {
            string s = "";
            return s;
        }*/

    }
}
