using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Net2Lecture180220WebShop.Models;

namespace Net2Lecture180220WebShop.Controllers
{
    public class CategoriesAndItemsController : Controller
    {
        List<Category> categories;
        List<ItemModel> items;
        public CategoriesAndItemsController() {
            categories = new List<Category>();
            categories.Add(new Category
            {
                ID = 1,
                name = "Phones"
            });
            categories.Add(new Category
            {
                ID = 2,
                name = "TV"
            });
            categories.Add(new Category
            {
                ID = 3,
                name = "Computers"
            });

            items = new List<ItemModel>();
            items.Add(new ItemModel
            {
                ID = 1,
                categoryId= 1,
                itemName = "Huawei Mate 20 Pro Twilight",
                category = "Phones",
                price = 612.00,
                description = "Ekrāna izmērs (collas): 6.39 " +
                "Izšķirtspēja: 3120 x 1440 " +
                "Iebūvētā atmiņa(ROM): 128 GB " +
                "Papildu atmiņa: Nano Memory līdz 256 GB " +
                "Kamera aizmugurē: 40 + 20 + 8 MP " +
                "SIM kartes tips: Nano SIM " +
                "Operētājsistēma: Android",
                location = "Riga"
            });
            items.Add(new ItemModel
            {
                ID = 2,
                categoryId = 1,
                itemName = "Huawei Mate 20 Pro Twilight",
                category = "Phones",
                price = 612.00,
                description = "Ekrāna izmērs (collas): 6.39 " +
                "Izšķirtspēja: 3120 x 1440 " +
                "Iebūvētā atmiņa(ROM): 128 GB " +
                "Papildu atmiņa: Nano Memory līdz 256 GB " +
                "Kamera aizmugurē: 40 + 20 + 8 MP " +
                "SIM kartes tips: Nano SIM " +
                "Operētājsistēma: Android",
                location = "Riga"
            });
            items.Add(new ItemModel
            {
                ID = 3,
                categoryId = 1,
                itemName = "Huawei Mate 20 Pro Twilight",
                category = "Phones",
                price = 612.00,
                description = "Ekrāna izmērs (collas): 6.39 " +
                "Izšķirtspēja: 3120 x 1440 " +
                "Iebūvētā atmiņa(ROM): 128 GB " +
                "Papildu atmiņa: Nano Memory līdz 256 GB " +
                "Kamera aizmugurē: 40 + 20 + 8 MP " +
                "SIM kartes tips: Nano SIM " +
                "Operētājsistēma: Android",
                location = "Riga"
            });
            items.Add(new ItemModel
            {
                ID = 4,
                categoryId = 2,
                itemName = "Sony KD55XG8096BAEP",
                category = "TV",
                price = 621.00,
                description = "Izšķirtspēja: 3840 x 2160 (Ultra HD) " +
                "Ekrāna izmērs (collas): 55 " +
                "Ekrāna izmērs(cm): 139 cm " +
                "Smart TV: Ir " +
                "High Dynamic Range(HDR): Ir " +
                "Ekrāna tehnoloģija: LED " +
                "Attēla kvalitāte: Motionflow™ XR 400Hz",
                location = "Ogre"
            });
            items.Add(new ItemModel
            {
                ID = 5,
                categoryId = 2,
                itemName = "Sony KD55XG8096BAEP",
                category = "TV",
                price = 621.00,
                description = "Izšķirtspēja: 3840 x 2160 (Ultra HD) " +
                "Ekrāna izmērs (collas): 55 " +
                "Ekrāna izmērs(cm): 139 cm " +
                "Smart TV: Ir " +
                "High Dynamic Range(HDR): Ir " +
                "Ekrāna tehnoloģija: LED " +
                "Attēla kvalitāte: Motionflow™ XR 400Hz",
                location = "Ogre"
            });
            items.Add(new ItemModel
            {
                ID = 6,
                categoryId = 2,
                itemName = "Sony KD55XG8096BAEP",
                category = "TV",
                price = 621.00,
                description = "Izšķirtspēja: 3840 x 2160 (Ultra HD) " +
                "Ekrāna izmērs (collas): 55 " +
                "Ekrāna izmērs(cm): 139 cm " +
                "Smart TV: Ir " +
                "High Dynamic Range(HDR): Ir " +
                "Ekrāna tehnoloģija: LED " +
                "Attēla kvalitāte: Motionflow™ XR 400Hz",
                location = "Ogre"
            });
            items.Add(new ItemModel
            {
                ID = 7,
                categoryId = 3,
                itemName = "V130, Lenovo",
                category = "Computers",
                price = 359.99,
                description = "V130 15,6'' " +
                "portatīvais dators kas paredzēts ikdienas biznesa gaitām " +
                "un ietērpts elegantā, teksturētā apvalkā. " +
                "Jaudīgā Intel® tehnoloģija ļauj strādāt produktīvi, " +
                "savukārt uzlabotā drošība, aizsargās jūsu datus.",
                location = "Tukums"
            });
            items.Add(new ItemModel
            {
                ID = 8,
                categoryId = 3,
                itemName = "V130, Lenovo",
                category = "Computers",
                price = 359.99,
                description = "V130 15,6'' " +
                "portatīvais dators kas paredzēts ikdienas biznesa gaitām " +
                "un ietērpts elegantā, teksturētā apvalkā. " +
                "Jaudīgā Intel® tehnoloģija ļauj strādāt produktīvi, " +
                "savukārt uzlabotā drošība, aizsargās jūsu datus.",
                location = "Tukums"
            });
            items.Add(new ItemModel
            {
                ID = 9,
                categoryId = 3,
                itemName = "V130, Lenovo",
                category = "Computers",
                price = 359.99,
                description = "V130 15,6'' " +
                "portatīvais dators kas paredzēts ikdienas biznesa gaitām " +
                "un ietērpts elegantā, teksturētā apvalkā. " +
                "Jaudīgā Intel® tehnoloģija ļauj strādāt produktīvi, " +
                "savukārt uzlabotā drošība, aizsargās jūsu datus.",
                location = "Tukums"
            });

        }

        public IActionResult Categories()
        {
            return View(categories);
        }

        public IActionResult Items()
        {
            IEnumerable<ItemModel> orderedByPriceItems = 
                items.OrderByDescending(i=> i.price);
            return View(orderedByPriceItems);
        }

        public IActionResult ViewCategoriesItems(int Id)
        {
            var itemsInCategory = items.FindAll(i=> i.categoryId == Id);
           
            return View(itemsInCategory);
        }

        public IActionResult ViewItem(int id)
        {
            var item = items.Find(i => i.ID == id);
            return View(item);
        }
    }
}