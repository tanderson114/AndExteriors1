using Serenity.Navigation;
using Region1 = AndExteriors.Region1.Pages;

[assembly: NavigationMenu(7000, "Region1", icon: "icon-anchor")]
[assembly: NavigationLink(7100, "Region1/Customers", typeof(Region1.CustomerController), icon: "icon-wallet")]
[assembly: NavigationLink(7200, "Region1/Orders", typeof(Region1.OrderController), icon: "icon-basket-loaded")]
[assembly: NavigationLink(7300, "Region1/Products", typeof(Region1.ProductController), icon: "icon-present")]
[assembly: NavigationLink(7400, "Region1/Suppliers", typeof(Region1.SupplierController), icon: "icon-magic-wand")]
[assembly: NavigationLink(7500, "Region1/Shippers", typeof(Region1.ShipperController), icon: "icon-plane")]
[assembly: NavigationLink(7600, "Region1/Categories", typeof(Region1.CategoryController), icon: "icon-folder-alt")]
[assembly: NavigationLink(7700, "Region1/Regions", typeof(Region1.RegionController), icon: "icon-map")]
[assembly: NavigationLink(7800, "Region1/Territories", typeof(Region1.TerritoryController), icon: "icon-puzzle")]
[assembly: NavigationLink(7900, "Region1/Reports", typeof(Region1.ReportsController), icon: "icon-docs")]
