using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory_with_Point_of_Sale_System
{
    class Global
    {
        public static string name;
        public static string Qty;
        public static string Unit;
        public static string SellPrice;
        public static string prodType;
        public static string total;
        public static string ID;
        public static string Supp;
        public static string BaseP;
        public static string SellP;
        public static string Model;
        public static string PartNum;
        public static string Location;
        public static string SerialN;
        public static string EngineN;
        public static string BigItem;

        public static bool noDuplicate = true;


        public static bool seedsInventory = false;
        public static bool equipmentsInventory = false;
        public static bool othersInventory = false;

        public static bool editQuantity = false;

        //used in the payment process
        public static string[] prodName = new string[500];
        public static string[] prodQuantity = new string[500];
        public static double[] prodSales = new double[500];
        public static string[] prodOutQuantity = new string[500];
        public static string[] prodUnit = new string[500];
        public static string[] prodTypeArr = new string[500];
        public static double[] newQuantity = new double[500];

        public static bool panelHide = true;

        public static bool buttonSeedSelected = false;
        public static bool buttonEquipmentSelected = false;
        public static bool buttonOthersSelected = false;

        //inventory form, add and edit
        public static bool adding = false;
        public static bool editing = false;

        public static string advertisementName = "giphy1.gif";

        
        //report
        public static string dateFrom;
        public static string dateTo;
        public static string reportHeading;
        public static string seedQuantity;
        public static string seedAmount;
        public static string eqptQuantity;
        public static string eqptAmount;
        public static string othersQuantity;
        public static string othersAmount;


        public static string[] qtyPerMonth = new string[12];

        public static int[] qtyPerMonthInt = new int[12];

        public static int[] prodSalesMonthlyLevel = new int[12];
    }
}
