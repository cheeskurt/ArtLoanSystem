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
                    new Item { TheItem = "Canon EOS R50", ImageURL = "/images/canon-eos-r50.jpg" },
                    new Item { TheItem = "iPad Pro 11", ImageURL = "/images/ipad-pro.jpg" },
                    new Item { TheItem = "SD Card 128GB", ImageURL = "/images/sd-card.jpg" },
                    new Item { TheItem = "Acrylic Paint Set", ImageURL = "/images/acrylic-paints.jpg" },
                    new Item { TheItem = "Tripod", ImageURL = "/images/tripod.jpg" },
                };
                foreach (var i in items) context.Item.Add(i);
                context.SaveChanges();
            }

            // Seed Students
            if (!context.Student.Any())
            {
                var students = new Student[]
                {
                    new Student { AC = "AC001", FirstName = "Alice",   LastName = "Smith",   Class = Class.TWELVEAPA },
                    new Student { AC = "AC002", FirstName = "Bob",     LastName = "Johnson", Class = Class.ELEVENAPA },
                    new Student { AC = "AC003", FirstName = "Carol",   LastName = "Williams",Class = Class.THIRTEENPHO },
                    new Student { AC = "AC004", FirstName = "David",   LastName = "Brown",   Class = Class.TWELVEPHO },
                    new Student { AC = "AC005", FirstName = "Eva",     LastName = "Jones",   Class = Class.NINEART },
                };
                foreach (var s in students) context.Student.Add(s);
                context.SaveChanges();
            }

            // Seed Issues
            if (!context.Issue.Any())
            {
                var issues = new Issue[]
                {
                    new Issue {
                        DateIssued   = DateTime.Parse("2024-01-15"),
                        DateDue      = DateTime.Parse("2024-01-22"),
                        DateReturned = DateTime.Parse("2024-01-21")
                    },
                    new Issue {
                        DateIssued   = DateTime.Parse("2024-02-01"),
                        DateDue      = DateTime.Parse("2024-02-08"),
                        DateReturned = DateTime.Parse("2024-02-10")
                    },
                    new Issue {
                        DateIssued   = DateTime.Parse("2024-03-05"),
                        DateDue      = DateTime.Parse("2024-03-12"),
                        DateReturned = DateTime.Parse("2024-03-12")
                    },
                };
                foreach (var iss in issues) context.Issue.Add(iss);
                context.SaveChanges();
            }

            // Seed Stocks
            if (!context.Stock.Any())
            {
                var stocks = new Stock[]
                {
                    new Stock { TheStock = "Canon EOS R50 - Unit 1", ItemID = 1, Available = true  },
                    new Stock { TheStock = "Canon EOS R50 - Unit 2", ItemID = 1, Available = false },
                    new Stock { TheStock = "iPad Pro - Unit 1",      ItemID = 2, Available = true  },
                    new Stock { TheStock = "SD Card - Unit 1",       ItemID = 3, Available = true  },
                    new Stock { TheStock = "Acrylic Paint Set #1",   ItemID = 4, Available = false },
                    new Stock { TheStock = "Tripod - Unit 1",        ItemID = 5, Available = true  },
                };
                foreach (var st in stocks) context.Stock.Add(st);
                context.SaveChanges();
            }

            // Seed ItemIssues
            if (!context.ItemIssue.Any())
            {
                var itemIssues = new ItemIssue[]
                {
                    new ItemIssue { IssueID = 1, ItemID = 1, Category = Category.Photography, Condition = Condition.Excellent, Note = "No issues noted."           },
                    new ItemIssue { IssueID = 1, ItemID = 3, Category = Category.Storage,     Condition = Condition.Good,      Note = "Minor scratches on case."   },
                    new ItemIssue { IssueID = 2, ItemID = 2, Category = Category.Tablets,     Condition = Condition.Good,      Note = "Screen protector peeling."  },
                    new ItemIssue { IssueID = 2, ItemID = 4, Category = Category.Paints,      Condition = Condition.Poor,      Note = "Several colours running low."},
                    new ItemIssue { IssueID = 3, ItemID = 5, Category = Category.Photography, Condition = Condition.Damaged,   Note = "One leg latch is broken."   },
                };
                foreach (var ii in itemIssues) context.ItemIssue.Add(ii);
                context.SaveChanges();
            }
        }
    }
}