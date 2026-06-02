using WebApplication3.Models;
using System;
using System.Linq;
using WebApplication3.Areas.Identity.Data;

namespace WebApplication3.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ArtEquipmentContext context)
        {
            context.Database.EnsureCreated();

            // Seed Items
            if (!context.Item.Any())
            {
                var items = new Item[]
                {
                    new Item { TheItem = "Canon EOS R50",    ImageURL = "/images/canon-eos-r50.jpg"  },
                    new Item { TheItem = "iPad Pro 11",      ImageURL = "/images/ipad-pro.jpg"       },
                    new Item { TheItem = "SD Card 128GB",    ImageURL = "/images/sd-card.jpg"        },
                    new Item { TheItem = "Acrylic Paint Set",ImageURL = "/images/acrylic-paints.jpg" },
                    new Item { TheItem = "Tripod",           ImageURL = "/images/tripod.jpg"         },
                };
                foreach (var i in items) context.Item.Add(i);
                context.SaveChanges();
            }

            // Seed Students
            // Note: AC must be between 8–10 characters to satisfy [MinLength(8), MaxLength(10)]
            if (!context.Student.Any())
            {
                var students = new Student[]
                {
                    new Student { FirstName = "Alice", LastName = "Smith",    Class = Class.B1 },
                    new Student { FirstName = "Bob",   LastName = "Johnson",  Class = Class.B2 },
                    new Student { FirstName = "Carol", LastName = "Williams", Class = Class.B3 },
                    new Student { FirstName = "David", LastName = "Brown",    Class = Class.B4 },
                    new Student { FirstName = "Eva",   LastName = "Jones",    Class = Class.B5 },
                    new Student { FirstName = "Ethan", LastName = "Maine",    Class = Class.B6 },
                };
                foreach (var s in students) context.Student.Add(s);
                context.SaveChanges();
            }

            // Seed Issues
            if (!context.Issue.Any())
            {
                var issues = new Issue[]
                {
                    new Issue { DateIssued = DateTime.Parse("2024-01-15"), DateReturned = DateTime.Parse("2024-01-21") },
                    new Issue { DateIssued = DateTime.Parse("2024-02-01"), DateReturned = DateTime.Parse("2024-02-10") },
                    new Issue { DateIssued = DateTime.Parse("2024-03-05"), DateReturned = DateTime.Parse("2024-03-12") },
                };
                foreach (var iss in issues) context.Issue.Add(iss);
                context.SaveChanges();
            }

            // Seed Stocks
            // Stock only has StockID and ItemID — no name/label field
            if (!context.Stock.Any())
            {
                var stocks = new Stock[]
                {
                    new Stock { ItemID = 1 },
                    new Stock { ItemID = 1 },
                    new Stock { ItemID = 2 },
                    new Stock { ItemID = 3 },
                    new Stock { ItemID = 4 },
                    new Stock { ItemID = 5 },
                };
                foreach (var st in stocks) context.Stock.Add(st);
                context.SaveChanges();
            }

            // Seed ItemIssues
            if (!context.ItemIssue.Any())
            {
                var itemIssues = new ItemIssue[]
                {
                    new ItemIssue { IssueID = 1, ItemID = 1, Category = Category.Photography, Condition = Condition.Excellent, Note = "No issues noted."            },
                    new ItemIssue { IssueID = 1, ItemID = 3, Category = Category.Storage,     Condition = Condition.Good,      Note = "Minor scratches on case."    },
                    new ItemIssue { IssueID = 2, ItemID = 2, Category = Category.Tablets,     Condition = Condition.Good,      Note = "Screen protector peeling."   },
                    new ItemIssue { IssueID = 2, ItemID = 4, Category = Category.Paints,      Condition = Condition.Poor,      Note = "Several colours running low." },
                    new ItemIssue { IssueID = 3, ItemID = 5, Category = Category.Photography, Condition = Condition.Damaged,   Note = "One leg latch is broken."    },
                };
                foreach (var ii in itemIssues) context.ItemIssue.Add(ii);
                context.SaveChanges();
            }
        }
    }
}