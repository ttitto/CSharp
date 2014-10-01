namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    public static class TestCompanyHierarchy
    {
        static IProject operaSpy = new Project(
             "Opera Spy",
             new DateTime(2014, 2, 23),
             ProjectState.Closed,
             "Script to periodically take the loaded URLs in the opened windows and tabs of Opera browser and send them by email");

        static IProject hospitalTokuda = new Project(
            "Tokuda Care",
            new DateTime(2014, 5, 15),
            ProjectState.Open,
            "Patient management system for Tokuda Hospital");

        static IProject eShopWebSite = new Project(
            "EShop ASP.Net",
            new DateTime(2014, 7, 30),
            ProjectState.Open,
            "A website with ASP.Net for an australian trading company");

        static ISale operaSpySale = new Sale("Opera Spy", new DateTime(2014, 08, 15), 2340m);
        static ISale wordpressPortfolioTemplate = new Sale("Wordpress portfolio", new DateTime(2014, 03, 10), 220m);
        static ISale firealarm = new Sale("Firealarm game", new DateTime(2013, 07, 25), 2000m);
        static ISale memoryMatrix = new Sale("Memory Matrix", new DateTime(2014, 09, 5), 1800m);
        static ISale bankERP = new Sale("UCB ERP", new DateTime(2014, 02, 02), 20340m);

        static IEmployee pesho = new SalesEmployee(
            "pp",
            "Petar",
            "Petrov",
            20000m,
            Department.Sales,
            new List<ISale>() { operaSpySale, firealarm });

        static IEmployee gosho = new SalesEmployee(
            "gb",
            "Georgi",
            "Balabanov",
            24000m,
            Department.Sales,
            new List<ISale>() { wordpressPortfolioTemplate, memoryMatrix });

        static IEmployee marinka = new SalesEmployee(
            "md",
            "Marinka",
            "Dicheva",
            30000m,
            Department.Marketing,
            new List<ISale>() { bankERP });

        static IEmployee gergana = new Developer(
            "gm",
            "Gergana",
            "Mihailova",
            25000,
            Department.Production,
            new List<IProject>() { operaSpy, eShopWebSite, hospitalTokuda });

        static IEmployee dimana = new Developer(
            "dm",
            "Dimana",
            "Mihailova",
            28000,
            Department.Production,
            new List<IProject>() { operaSpy, hospitalTokuda });

        static IEmployee donka = new Developer(
            "dk",
            "Donka",
            "Karamanova",
            15000,
            Department.Production,
            new List<IProject>() { hospitalTokuda });

        static IManager petranka = new Manager(
            "pk",
            "Petranka",
            "Karadocheva",
            38000,
            Department.Production,
            new List<IEmployee>() { dimana, donka, });

        static IManager krastanka = new Manager(
           "kk",
           "Krastanka",
           "Kurteva",
           30000,
           Department.Production,
           new List<IEmployee>() { gergana });

        static IManager tsvetana = new Manager(
        "tm",
        "Tsvetana",
        "Marinova",
        35000,
        Department.Marketing,
        new List<IEmployee>() { pesho, gosho, marinka });

        public static IList<IEmployee> employees = new List<IEmployee>() { 
            pesho, gosho, marinka, gergana, tsvetana, krastanka, petranka, donka, dimana, };
    }
}