using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop_11_4.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Eshop_11_4.Models
{
    public class SeedData
    {



        public static void EnsurePopulated(IApplicationBuilder app)
        {


            ApplicationDbContext context = app.ApplicationServices
             .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.ProductTypes.Any())
            {
                context.ProductTypes.AddRange(
                    new ProductType
                    {
                        Name = "Καρέκλες",
                        Image = "https://images.unsplash.com/photo-1493150134366-cacb0bdc03fe?ixlib=rb-1.2.1&auto=format&fit=crop&w=750&q=80",
                        Show = true
                    },

                    new ProductType
                    {
                        Name = "Βιβλιοθήκες",
                        Image = "https://images.unsplash.com/photo-1507842217343-583bb7270b66?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=853&q=80",
                        Show = true
                    },

                    new ProductType
                    {
                        Name = "Καναπέδες",
                        Image = "https://images.unsplash.com/photo-1505691938895-1758d7feb511?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80",
                        Show = true
                    },

                    new ProductType
                    {
                        Name = "Έπιπλα τηλεόρασης",
                        Image = "https://images.unsplash.com/photo-1461151304267-38535e780c79?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=890&q=80",
                        Show = true
                    },

                    new ProductType
                    {
                        Name = "Πολυθρόνες",
                        Image = "https://images.unsplash.com/photo-1465224414649-ceb7f1db3999?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80",
                        Show = true
                    },

                    new ProductType
                    {
                        Name = "Γραφεία",
                        Image = "https://images.unsplash.com/photo-1548611716-3000815a5803?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80",
                        Show = true
                    },

                    new ProductType
                    {
                        Name = "Κρεβάτια",
                        Image = "https://images.unsplash.com/photo-1543490791-db8323d8e5b2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80",
                        Show = true
                    },

                    new ProductType
                    {
                        Name = "Κομοδίνα",
                        Image = "https://images.unsplash.com/photo-1455792244736-3ed96c3d7f7e?ixlib=rb-1.2.1&auto=format&fit=crop&w=375&q=80",
                        Show = true
                    },


                    new ProductType
                    {
                        Name = "Ντουλάπια",
                        Image = "https://images.unsplash.com/photo-1545060894-a74591e187f0?ixlib=rb-1.2.1&auto=format&fit=crop&w=387&q=80",
                        Show = true
                    },

                    new ProductType
                    {
                        Name = "Τραπέζια",
                        Image = "https://images.unsplash.com/photo-1530018607912-eff2daa1bac4?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=751&q=80",
                        Show = true
                    });
                context.SaveChanges();
            }

            if (!context.Rooms.Any())
            {
                context.Rooms.AddRange(
                    new Room
                    {
                        Name = "Κουζίνα",
                        Image = "https://images.unsplash.com/photo-1507089947368-19c1da9775ae?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=755&q=80",
                        Show = true
                    },

                    new Room
                    {
                        Name = "Γραφείο",
                        Image = "https://images.unsplash.com/photo-1506188232657-23c9c893ac2b?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80",
                        Show = true
                    },

                    new Room
                    {
                        Name = "Τραπεζαρία",
                        Image = "https://images.unsplash.com/photo-1537726235470-8504e3beef77?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80",
                        Show = true
                    },

                    new Room
                    {
                        Name = "Υπνοδωμάτιο",
                        Image = "https://images.unsplash.com/photo-1531835551805-16d864c8d311?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=334&q=80",
                        Show = true
                    },

                    new Room
                    {
                        Name = "Σαλόνι",
                        Image = "https://images.unsplash.com/photo-1523755231516-e43fd2e8dca5?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=375&q=80",
                        Show = true
                    });
                context.SaveChanges();
            }

            //if (!context.Users.Any())
            //{
            //    context.Users.AddRange(
            //        new AuthenticateUser
            //        {
            //            UserName = "takis@gmail.com",
            //            Email = "takis@gmail.com"
            //        },

            //        new AuthenticateUser
            //        {
            //            UserName = "el@gmail.com",
            //            Email = "el@gmail.com"
            //        });
            //    context.SaveChanges();
            //}

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Κάθισμα Alison",
                        Description = "Καρέκλα με μεταλλικό σκελετό σε μαύρο χρώμα και επένδυση microfibra Easy Clean σε γκρι απόχρωση με διακριτικό γεωμετρικό σχέδιο ραφής στην πλάτη και το κάθισμα.",
                        Image = "https://www.marmaridis.gr/images/uploads/Alison.jpg",
                        Price = 60,
                        Stock = 7,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 1,
                        RoomId = 1
                    },

                    new Product
                    {
                        Name = "Κάθισμα Brooklyn Sand",
                        Description = "Κάθισμα δείπνου με μεταλλικό σκελετό σε χρώμα αλουμινίου και microfibra Easy Clean σε απόχρωση Sand.",
                        Image = "https://www.marmaridis.gr/images/uploads/Indila_grey_grey_frontsalee414.jpg",
                        Price = 70,
                        Stock = 15,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 1,
                        RoomId = 1
                    },

                    new Product
                    {
                        Name = "Κάθισμα Indila beige-brown",
                        Description = "Κάθισμα σε retro-μοντέρνα γραμμή με σώμα από καφε PVC, αναπαυτικό μαξιλάρι και ξύλινα πόδια.",
                        Image = "https://www.marmaridis.gr/images/uploads/Indila_grey_grey_frontsalee1.jpg",
                        Price = 45,
                        Stock = 23,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 1,
                        RoomId = 1
                    },

                    new Product
                    {
                        Name = "Κάθισμα Alambra",
                        Description = "Aναπαυτικό κάθισμα με ψηλή πλάτη και επένδυση σε μπεζ microfibra Easy Clean.",
                        Image = "https://www.marmaridis.gr/images/uploads/ALAMBRA_PLAINO.jpg",
                        Price = 27,
                        Stock = 34,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 1,
                        RoomId = 1
                    },

                    new Product
                    {
                        Name = "Κάθισμα Floresta",
                        Description = "Καρέκλα τραπεζαρίας, με σκελετό από ξύλο, χαμηλή ημικυκλική πλάτη σε κομψή, μοντέρνα γραμμή και αναπαυτικό κάθισμα με επένδυση microfibra Easy Clean.",
                        Image = "https://www.marmaridis.gr/images/uploads/Floresta.jpg",
                        Price = 70,
                        Stock = 7,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 1,
                        RoomId = 1
                    },


                    new Product
                    {
                        Name = "Βιβλιοθήκη Eta",
                        Description = "Πρακτική βιβλιοθήκη σε μεγάλο μέγεθος με ανοιχτά και κλειστά ράφια, με διχρωμία σταχτί και λευκό σε αχάρακτο συνθετικό καπλαμά.",
                        Image = "https://www.marmaridis.gr/images/uploads/Eta_VIVLIOTHIKI.jpg",
                        Price = 300,
                        Stock = 5,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 2,
                        RoomId = 2
                    },

                    new Product
                    {
                        Name = "Βιβλιοθήκη Mod782655",
                        Description = "Μοντέρνα σύνθεση ραφιών - βιβλιοθήκη με ντουλάπια αποθήκευσης και επένδυση από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά σε σκούρη απόχρωση",
                        Image = "https://www.marmaridis.gr/images/uploads/modul26.jpg",
                        Price = 400,
                        Stock = 7,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 2,
                        RoomId = 2
                    },

                    new Product
                    {
                        Name = "Βιβλιοθήκη Mod782755",
                        Description = "Μοντέρνα σύνθεση ραφιών - βιβλιοθήκη με ντουλάπια αποθήκευσης και επένδυση από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά σε σκούρη απόχρωση.",
                        Image = "https://www.marmaridis.gr/images/uploads/modul27.jpg",
                        Price = 70,
                        Stock = 12,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 2,
                        RoomId = 2
                    },

                    new Product
                    {
                        Name = "Βιβλιοθήκη Mod782355",
                        Description = "Μοντέρνα σύνθεση ραφιών - βιβλιοθήκη με επένδυση από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά σε σκούρη απόχρωση",
                        Image = "https://www.marmaridis.gr/images/uploads/modul23.jpg",
                        Price = 270,
                        Stock = 10,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 2,
                        RoomId = 2
                    },

                    new Product
                    {
                        Name = "Βιβλιοθήκη Barney",
                        Description = "Βιβλιοθήκη σε κλασικό στυλ με ταμπλαδοτά ντουλάπια, καμπυλωτές λεπτομέρειες και επένδυση από φυσικό καπλαμά καρυδιάς σε κοκκινωπή απόχρωση. Διαθέτει δύο βιτρίνες, πολλά ντουλάπια και δύο συρτάρια. Ιδανική για κάθε περιβάλλον, οικιακό αλλά και επαγγελματικό, τακτοποιεί τον χώρο σας, προσδίδει κύρος και αρχοντιά ικανοποιώντας πλήρως του λάτρεις της κλασικής αισθητικής. Συνδυάζεται τέλεια με τα σετ γραφείου Aderson και Barney.",
                        Image = "https://www.marmaridis.gr/images/uploads/Barney_decor.jpg",
                        Price = 375,
                        Stock = 5,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 2,
                        RoomId = 2
                    },

                    new Product
                    {
                        Name = "3Θ Καναπές - Κρεβάτι Kythira",
                        Description = "Τριθέσιος καναπές - κρεβάτι , σε καρέ γραμμή, εξαιρετικής ποιότητας κατασκευής, με ελαστικούς ιμάντες για αναπαυτικό κάθισμα, ύφασμα microfibra Easy Clean αφαιρούμενο στα μαξιλάρια πλάτης και καθίσματος και εξώραφες λεπτομέρειες",
                        Image = "https://www.marmaridis.gr/images/uploads/Kythira_bed_anna_close.jpg",
                        Price = 999,
                        Stock = 8,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 3,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "2Θ Kαναπές Marbella",
                        Description = "Εντυπωσιακός καναπές με φαρδύ αναπαυτικό κάθισμα, ανατομική πλάτη δύο θέσεων και μοντέρνο design.",
                        Image = "https://www.marmaridis.gr/images/uploads/marbella2_2_seat_2.jpg",
                        Price = 300,
                        Stock = 5,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 3,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "Kαναπές γωνία Isla",
                        Description = "Καναπές γωνία υψηλής ποιότητας κατασκευής με αναπαυτικό κάθισμα και μεγάλα αφράτα μαξιλάρια πλάτης και φιγούρας. Διαθέτει μοντέρνα σχεδίαση και inox πόδια που απογειώνουν το επίπεδο της άνεσης και της εμφάνισης του σαλονιού.",
                        Image = "https://www.marmaridis.gr/images/uploads/isla_corner_side.jpg",
                        Price = 1700,
                        Stock = 4,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 3,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "Kαναπές γωνία Kentuky",
                        Description = "Εντυπωσιακός καναπές γωνία σε διάταξη τόξου, με βαθύ άνετο, αφράτο κάθισμα και ενσωματωμένο σύστημα με 2 μηχανισμούς ρηλάξ τύπου bucket, και επένδυση από εξελιγμένο  3ης γενιάς τεχνόδερμα.",
                        Image = "https://www.marmaridis.gr/images/uploads/%CE%9A%CE%95%CE%9D%CE%A4%CE%91%CE%9A%CE%992_open.jpg",
                        Price = 400,
                        Stock = 7,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 3,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "Καναπές γωνία Lana",
                        Description = "Καναπές γωνία, σε μοντέρνο σχεδιασμό και λειτουργικές διαστάσεις με κρεβάτι και αποθηκευτικό χώρο. Διαθέτει φαρδύ ανάκλινδρο και βαθύ, αναπαυτικό κάθισμα .Με επένδυση υφάσματος σε γκρι απόχρωση  αποτελεί μια ασφαλή επιλογή που ταιριάζει σε κάθε σπίτι, προσδίδοντας στυλ και εξυπηρετώντας ανάγκες φιλοξενίας.",
                        Image = "https://www.marmaridis.gr/images/uploads/Lana.jpg",
                        Price = 180,
                        Stock = 20,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 3,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "Έπιπλο TV Othello wenge",
                        Description = "Πρακτικό έπιπλο TV, minimal σχεδιασμού με επένδυση από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά σε wenge απόχρωση.",
                        Image = "https://www.marmaridis.gr/images/uploads/OTHELLO_WENGE__TV_DECOR.jpg",
                        Price = 304,
                        Stock = 10,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 4,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "Έπιπλο TV Livorno",
                        Description = "Έπιπλo TV μοναστηριακού τύπου, από μασίφ κομμάτια ξύλου με ειδική επεξεργασία για εντυπωσιακό ανάγλυφο αποτέλεσμα και μεταλλικές «ζώνες» που αγκαλιάζουν την επιφάνεια. Στην ίδια σειρά διατίθεται τραπέζι σαλονιού, τραπέζι δείπνου και  bench-πάγκος τραπεζαρίας.",
                        Image = "https://www.marmaridis.gr/images/uploads/LIVORNO_TV__DECOR.jpg",
                        Price = 264,
                        Stock = 17,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 4,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "Έπιπλο TV Mon Repos",
                        Description = "Έπιπλο TV υψηλής αισθητικής σε νεοκλασική γραμμή, με μασίφ στοιχεία, τεχνητή παλαίωση και εντυπωσιακή μαρκετερί τριών αποχρώσεων.",
                        Image = "https://www.marmaridis.gr/images/uploads/MON-REPOS_TV.jpg",
                        Price = 239,
                        Stock = 12,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 4,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "Έπιπλο TV Barnes",
                        Description = "Έπιπλο TV από μασίφ ξύλο φυσικής απόχρωσης, σε μοντέρνο συνδυασμό με στοιχεία σε γκρι ανάγλυφη λάκα. Στην ίδια σειρά διατίθενται τραπέζι δείπνου, bench-πάγκο τραπεζαρίας, μπουφές, κονσόλα, τραπέζι σαλονιού, σύνθετο και σετ κρεβατοκάμαρας.",
                        Image = "https://www.marmaridis.gr/images/uploads/BARNES_EPIPLO_TV.jpg",
                        Price = 104,
                        Stock = 11,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 4,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "Έπιπλο ΤV Alley",
                        Description = "Έπιπλο TV σε μοντέρνα κυβιστική σχεδίαση, με επένδυση από φυσικό καπλαμά σε συνδυασμό wenge και λευκού με ειδική ανάγλυφη επεξεργασία.",
                        Image = "https://www.marmaridis.gr/images/uploads/ALLEY_TV_PODARAKIA_CMYK.jpg",
                        Price = 109,
                        Stock = 20,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 4,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "Πολυθρόνα Marilyn",
                        Description = "Πολυθρόνα RELAX με ψηλή πλάτη και αναπαυτικό κάθισμα, με μηχανισμό ανάκλισης πολλών θέσεων μέσω ενσωματωμένο κουμπιού που την κάνει πολυθρόνα-κρεβάτι. Διατίθεται σε γκρι microfibra Easy Clean.",
                        Image = "https://www.marmaridis.gr/images/uploads/Marilyn.jpg",
                        Price = 199,
                        Stock = 10,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 5,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "Πολυθρόνα Ragya sand",
                        Description = "Πολυθρόνα RELAX σε microfibra Easy Clean, με μηχανισμό ανάκλισης και εξαιρετικά αναπαυτικό κάθισμα. Διαθέσιμο σε sand απόχρωση.",
                        Image = "https://www.marmaridis.gr/images/uploads/RAGYA_open.jpg",
                        Price = 329,
                        Stock = 15,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 5,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "Πολυθρόνα Alin beige",
                        Description = "Πολυθρόνα RELAX σε microfibra Easy Clean, με μηχανισμό ανάκλισης και εξαιρετικά αναπαυτικό κάθισμα με επιπλέον θέση για ποτήρια στα μπράτσα. Διαθέσιμο σε sand απόχρωση.",
                        Image = "https://www.marmaridis.gr/images/uploads/POLYTHRONA_ALIN_OPEN.jpg",
                        Price = 299,
                        Stock = 21,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 5,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "Πολυθρόνα Derby Silver",
                        Description = "Πολυθρόνα με ψηλή χαμηλή και αναπαυτικό κάθισμα, με επένδυση σε βελουτέ ύφασμα. Συνοδεύεται από βολικό υποπόδιο-σκαμπό που μπορείτε να αποθηκεύσετε από κάτω",
                        Image = "https://www.marmaridis.gr/images/uploads/djerba_silver_side.jpg",
                        Price = 239,
                        Stock = 16,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 5,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "Πολυθρόνα SO2438",
                        Description = "Πολυθρόνα σε μοντέρνο design, από διάφανο ακρυλικό με μαύρο αποσπώμενο μαξιλάρι.",
                        Image = "https://www.marmaridis.gr/images/uploads/Madison.jpg",
                        Price = 279,
                        Stock = 19,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 5,
                        RoomId = 5
                    },

                    new Product
                    {
                        Name = "Γραφείο Barnes",
                        Description = "Γραφείο από μασίφ ξύλο φυσικής απόχρωσης, με στοιχεία σε γκρι ανάγλυφη λάκα. Στην ίδια σειρά διατίθενται τραπέζι δείπνου, bench-πάγκος τραπεζαρίας, μπουφές, έπιπλο TV, τραπέζι σαλονιού, κονσόλα, σύνθετο και σετ κρεβατοκάμαρας.",
                        Image = "https://www.marmaridis.gr/images/uploads/BARNES_GRAFEIO.jpg",
                        Price = 229,
                        Stock = 17,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 6,
                        RoomId = 2
                    },

                    new Product
                    {
                        Name = "Γραφείο Turm",
                        Description = "Μοντέρνο γραφείο σε ξανθή απόχρωση με μεταλλικές inox βάσεις και επιφάνειες από μασίφ ξύλο δρυός. Επίσης διαθέτει χώρο με 3 ενσωματωμένα συρτάρια για αρχειοθέτηση και αποθήκευση.",
                        Image = "https://www.marmaridis.gr/images/uploads/Turm_desk.jpg",
                        Price = 59,
                        Stock = 23,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 6,
                        RoomId = 2
                    },

                    new Product
                    {
                        Name = "Γραφείο Byron",
                        Description = "Γραφείο από άθραυστο κρύσταλλο tempered glass μεταλλικά μέρη, διατρητή όψη και inox βάση.",
                        Image = "https://www.marmaridis.gr/images/uploads/byron_desk.jpg",
                        Price = 109,
                        Stock = 1,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 6,
                        RoomId = 2
                    },

                    new Product
                    {
                        Name = "Γραφείο Arthur",
                        Description = "Γραφείο σε μαύρη με καρυδί απόχρωση και άθραυστο κρύσταλλο και μεταλλικές βάσεις, θέση και χώρος αρχειοθέτησης ",
                        Image = "https://www.marmaridis.gr/images/uploads/Arthur.jpg",
                        Price = 279,
                        Stock = 14,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 6,
                        RoomId = 2
                    },

                    new Product
                    {
                        Name = "Παιδικό σετ Puzzle Magenta",
                        Description = "Πολυμορφικό παιδικό σετ που αποτελείται από υπερυψωμένο κρεβάτι, εσωτερικά ράφια και ενσωματωμένο συρόμενο γραφείο με δυνατότητα εξωτερικής τοποθέτησης, δημιουργώντας επιπλέον χώρους για αποθήκευση ή παιχνίδι. Ιδανική λύση για μικρά παιδικά δωμάτια! Διατίθεται σε 4 χρωματικούς συνδυασμούς: λευκό και μωβ, λευκό και φουξ, λευκό και γαλάζιο, λευκό και λαχανί. ",
                        Image = "https://www.marmaridis.gr/images/uploads/puzzle_magenta.jpg",
                        Price = 229,
                        Stock = 12,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 6,
                        RoomId = 2
                    },

                    new Product
                    {
                        Name = "Κρεβάτι Berkley sand 120",
                        Description = "Κρεβάτι με εντυπωσιακό καπιτονέ κεφαλάρι με επένδυση σε μπεζ microfibra Easy Clean και ορθοπεδικό σωμιέ. Διαθέσιμο σε γκρι και μπεζ",
                        Image = "https://www.marmaridis.gr/images/uploads/Berkley_120_sand.jpg",
                        Price = 220,
                        Stock = 12,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 7,
                        RoomId = 4
                    },

                    new Product
                    {

                        Name = "Κρεβάτι Berkley grey 90",
                        Description = "Κρεβάτι με εντυπωσιακό καπιτονέ κεφαλάρι με επένδυση σε γκρι microfibra Easy Clean και ορθοπεδικό σωμιέ. Διαθέσιμο σε γκρι και μπεζ",
                        Image = "https://www.marmaridis.gr/images/uploads/Berkley_grey_mono.jpg",
                        Price = 299,
                        Stock = 10,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 7,
                        RoomId = 4
                    },

                    new Product
                    {
                        Name = "Kρεβάτι 78201055 walnut",
                        Description = "Διπλό κρεβάτι από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά, σε καρυδί απόχρωση, με ιδιαίτερο σχέδιο στο κεφαλάρι.",
                        Image = "https://www.marmaridis.gr/images/uploads/78201055_walnut2.jpg",
                        Price = 259,
                        Stock = 14,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 7,
                        RoomId = 4
                    },

                    new Product
                    {
                        Name = "Kρεβάτι 78200855 wenge",
                        Description = "Διπλό κρεβάτι από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά, σε wenge απόχρωση, με ιδιαίτερο σχέδιο στο κεφαλάρι.",
                        Image = "https://www.marmaridis.gr/images/uploads/78201055_wenge2.jpg",
                        Price = 329,
                        Stock = 9,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 7,
                        RoomId = 4
                    },

                    new Product
                    {
                        Name = "Kρεβάτι 78200855 sonoma",
                        Description = "Διπλό κρεβάτι από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά, σε σταχτί απόχρωση, με ιδιαίτερο σχέδιο στο κεφαλάρι.",
                        Image = "https://www.marmaridis.gr/images/uploads/78201055_sonoma2.jpg",
                        Price = 219,
                        Stock = 17,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 7,
                        RoomId = 4
                    },

                    new Product
                    {
                        Name = "Κομοδίνο Berkley Grey",
                        Description = "Eυρύχωρο κομοδίνο σε grey απόχρωση επενδεδυμένο με ύφασμα microfibra Easy Clean.",
                        Image = "https://www.marmaridis.gr/images/uploads/Komodino_bekerley_grey_side.jpg",
                        Price = 60,
                        Stock = 18,
                        DateCreated = new DateTime(2019, 4, 22),
                        DateUpdated = new DateTime(2019, 4, 22),
                        Show = true,
                        ProductTypeId = 8,
                        RoomId = 4
                    },

                     new Product
                     {
                         Name = "Κομοδίνο Natali sonoma",
                         Description = "Δίχρωμο ευρύχωρο κομοδίνο σε σταχτί απόχρωση ξύλου με καρυδί στοιχεία και τεχνοτροπία παλαίωσης",
                         Image = "https://www.marmaridis.gr/images/uploads/KOMODINO_NATALI_STAXTI.jpg",
                         Price = 55,
                         Stock = 14,
                         DateCreated = new DateTime(2019, 4, 22),
                         DateUpdated = new DateTime(2019, 4, 22),
                         Show = true,
                         ProductTypeId = 8,
                         RoomId = 4
                     },

                     new Product
                     {
                         Name = "Κομοδίνο Natali walnut",
                         Description = "Δίχρωμο ευρύχωρο κομοδίνο σε walnut με ανταύγειες και στοιχεία με εμφάνιση λευκής βαφής παλαίωσης",
                         Image = "https://www.marmaridis.gr/images/uploads/KOMODINO_NATALI_KARUDI.jpg",
                         Price = 49,
                         Stock = 4,
                         DateCreated = new DateTime(2019, 4, 22),
                         DateUpdated = new DateTime(2019, 4, 22),
                         Show = true,
                         ProductTypeId = 8,
                         RoomId = 4
                     },

                     new Product
                     {
                         Name = "Κομοδίνο Nefeli wenge",
                         Description = "Δίχρωμο ευρύχωρο κομοδίνο σε wenge απόχρωση με στοιχεία σε τεχνοτροπία λευκής βαφής παλαίωσης.",
                         Image = "https://www.marmaridis.gr/images/uploads/KOMODINO_NEFELI_WENGE.jpg",
                         Price = 69,
                         Stock = 8,
                         DateCreated = new DateTime(2019, 4, 22),
                         DateUpdated = new DateTime(2019, 4, 22),
                         Show = true,
                         ProductTypeId = 8,
                         RoomId = 4
                     },

                     new Product
                     {
                         Name = "Κομοδίνο Ridi",
                         Description = "Κομοδίνο με δύο συρτάρια, από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά σε απόχρωση wenge",
                         Image = "https://www.marmaridis.gr/images/uploads/Ridi.jpg",
                         Price = 63,
                         Stock = 7,
                         DateCreated = new DateTime(2019, 4, 22),
                         DateUpdated = new DateTime(2019, 4, 22),
                         Show = true,
                         ProductTypeId = 8,
                         RoomId = 4
                     },

                     new Product
                     {
                         Name = "Nτουλάπα 78101755",
                         Description = "Ντουλάπα με επένδυση από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά σε μοντέρνα σκούρη απόχρωση, που περιλαμβάνει εσωτερικά ράφια και ράγες κρέμασης ρούχων.",
                         Image = "https://www.marmaridis.gr/images/uploads/1017_2.jpg",
                         Price = 105,
                         Stock = 10,
                         DateCreated = new DateTime(2019, 4, 22),
                         DateUpdated = new DateTime(2019, 4, 22),
                         Show = true,
                         ProductTypeId = 9,
                         RoomId = 1
                     },

                     new Product
                     {
                         Name = "Nτουλάπα 78101655",
                         Description = "Ντουλάπα σε λειτουργικές διαστάσεις με επένδυση από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά σε σταχτί απόχρωση ξύλου",
                         Image = "https://www.marmaridis.gr/images/uploads/1016.jpg",
                         Price = 150,
                         Stock = 9,
                         DateCreated = new DateTime(2019, 4, 22),
                         DateUpdated = new DateTime(2019, 4, 22),
                         Show = true,
                         ProductTypeId = 9,
                         RoomId = 1
                     },

                     new Product
                     {
                         Name = "Ντoυλάπα 78100155 walnut",
                         Description = "Μοντέρνα ντουλάπα με αποθηκευτικούς χώρους, επένδυση από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά σε καρυδί απόχρωση.",
                         Image = "https://www.marmaridis.gr/images/uploads/78100155_ntoulapa_new_karudi.jpg",
                         Price = 162,
                         Stock = 12,
                         DateCreated = new DateTime(2019, 4, 22),
                         DateUpdated = new DateTime(2019, 4, 22),
                         Show = true,
                         ProductTypeId = 9,
                         RoomId = 1
                     },

                     new Product
                     {
                         Name = "Ντoυλάπα 78100155 gold oak",
                         Description = "Μοντέρνα ντουλάπα με αποθηκευτικούς χώρους, επένδυση από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά σε gold oak απόχρωση.",
                         Image = "https://www.marmaridis.gr/images/uploads/78100155_ntoulapa_new.jpg",
                         Price = 122,
                         Stock = 14,
                         DateCreated = new DateTime(2019, 4, 22),
                         DateUpdated = new DateTime(2019, 4, 22),
                         Show = true,
                         ProductTypeId = 9,
                         RoomId = 1
                     },

                     new Product
                     {
                         Name = "Ντoυλάπα 78100155",
                         Description = "Μοντέρνα ντουλάπα σε σταχτί απόχρωση με wenge στοιχεία.",
                         Image = "https://www.marmaridis.gr/images/uploads/78100155_mix.jpg",
                         Price = 199,
                         Stock = 7,
                         DateCreated = new DateTime(2019, 4, 22),
                         DateUpdated = new DateTime(2019, 4, 22),
                         Show = true,
                         ProductTypeId = 9,
                         RoomId = 1
                     },

                     new Product
                     {
                         Name = "Τραπεζαρία Santander wenge & 6αδα Cuadra",
                         Description = "Σετ τραπεζαρίας που περιλαμβάνει επεκτεινόμενο τραπέζι δείπνου με εντυπωσιακή χιαστή βάση και επιφάνεια σε ρουστίκ δρυ. Συνοδεύεται από καθίσματα Cuadra με αναπαυτικό κάθισμα χαμηλή πλάτη σε μπεζ microfibra Easy Clean, wenge σκελετό και ένα πρωτότυπο άνοιγμα στην πλάτη. Πρόκειται για ένα σετ που πρωταγωνιστεί λειτουργικά στoν χώρο σας και τον στολίζει με πρωτότυπη αισθητική που μαγνητίζει τα βλέμματα.",
                         Image = "https://www.marmaridis.gr/images/uploads/Santander_wenge_6_cuadra_decor.jpg",
                         Price = 320,
                         Stock = 6,
                         DateCreated = new DateTime(2019, 4, 22),
                         DateUpdated = new DateTime(2019, 4, 22),
                         Show = true,
                         ProductTypeId = 10,
                         RoomId = 3
                     },

                     new Product
                     {
                         Name = "Τραπεζαρία Hydra & 6αδα Brooklyn red",
                         Description = "Σετ τραπεζαρίας που αποτελείται από τραπέζι δείπνου με επένδυση από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά σε σταχτί απόχρωση ξύλου, minimal αισθητικής και μεγάλων διαστάσεων. Συνοδεύεται από 6 καθίσματα Brooklyn με επένδυση microfibra Easy Clean σε απόχρωση red.",
                         Image = "https://www.marmaridis.gr/images/uploads/HYDRA_6_BROOKLYN_%CF%81%CE%B5%CE%B4_DECOR.jpg",
                         Price = 289,
                         Stock = 3,
                         DateCreated = new DateTime(2019, 4, 22),
                         DateUpdated = new DateTime(2019, 4, 22),
                         Show = true,
                         ProductTypeId = 10,
                         RoomId = 3
                     },

                     new Product
                     {
                         Name = "Σετ τραπεζαρίας Maex με 4 καθίσματα",
                         Description = "Μοντέρνο τραπέζι από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά σε απόχρωση καρυδί. Συνοδεύεται από τέσσερα αναπαυτικά καθίσματα σε γκρι ύφασμα τα οποία αποθηκεύονται από κάτω του. Ένα έξυπνο σετ για περιορισμένο χώρο.",
                         Image = "https://www.marmaridis.gr/images/uploads/MAEX_DINNER_OPEN.jpg",
                         Price = 400,
                         Stock = 9,
                         DateCreated = new DateTime(2019, 4, 22),
                         DateUpdated = new DateTime(2019, 4, 22),
                         Show = true,
                         ProductTypeId = 10,
                         RoomId = 3
                     },

                     new Product
                     {
                         Name = "Τραπεζαρία Hydra & 6αδα Indila",
                         Description = "Σετ τραπεζαρίας που αποτελείται από τραπέζι δείπνου με επένδυση από υψηλής ποιότητας, αχάρακτο συνθετικό καπλαμά σε απόχρωση gold oak. Συνοδεύεται από 6 καθίσματα Indila σε retro-μοντέρνα γραμμή σε σώμα απο γκρι PVC, αναπαυτικό μαξιλάρι, και ξύλινα πόδια.",
                         Image = "https://www.marmaridis.gr/images/uploads/HYDRA_GOLD_OAK_6_INDILA_DECOR2.jpg",
                         Price = 244,
                         Stock = 8,
                         DateCreated = new DateTime(2019, 4, 22),
                         DateUpdated = new DateTime(2019, 4, 22),
                         Show = true,
                         ProductTypeId = 10,
                         RoomId = 3
                     },

                     new Product
                     {
                         Name = "Τραπεζαρία Provence & 6αδα Letus",
                         Description = "Σετ τραπεζαρίας που περιλαμβάνει μοντέρνας αισθητικής τραπέζι δείπνου, με επιφάνεια από φυσικό καπλαμά δρυς σε ανοιχτόχρωμη απόχρωση καρυδιάς και λευκά στοιχεία σε όψη μαρμάρου στα χαρακτηριστικά πόδια του Συνοδεύεται από 6 καθίσματα με ιδιαίτερα αναπαυτικό κάθισμα με inox σκελετό και εντυπωσιακή καπιτονέ πλάτη, σε μοντέρνα μπεζ απόχρωση.",
                         Image = "https://www.marmaridis.gr/images/uploads/PROVENCE_LETUS_DECOR.jpg",
                         Price = 345,
                         Stock = 7,
                         DateCreated = new DateTime(2019, 4, 22),
                         DateUpdated = new DateTime(2019, 4, 22),
                         Show = true,
                         ProductTypeId = 10,
                         RoomId = 3
                     }
                    );
                context.SaveChanges();
            }
        }
    }
}