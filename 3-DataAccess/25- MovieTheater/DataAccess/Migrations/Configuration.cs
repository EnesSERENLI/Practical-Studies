namespace DataAccess.Migrations
{
    using DataAccess.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.Context.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataAccess.Context.ProjectContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            if (!context.Movies.Any())
            {
                Movie movie1 = new Movie("Hotaru no haka", "Genç bir çocuk ve küçük kız kardeşi, İkinci Dünya Savaşı sırasında Japonyada hayatta kalma mücadelesi veriyor.", 89);
                Movie movie2 = new Movie("American History X", "Eski bir neo-nazi dazlak kardeşinin onun yaptığı aynı yanlış yola girmesini engellemeye çalışır.", 119);
                Movie movie3 = new Movie("Whiplash", "Genç öğrenci Andrew davul çalma işinde gelecek vaat eden biridir ve her zaman bu iş de en iyisi olmak istemiştir. Bu yüzden çok zorlu bir konservatuar imtihanına hazırlanan Andrew ünlü müzisyenlerden birinden ders almaya karar vermiştir.Fakat hocası Terence Fletcher genç öğrencinin kapasitesinin tam anlamıyla doruklarına çıkmadan onu zorlamaktan vazgeçmeyecektir.", 107);
                Movie movie4 = new Movie("The Departed", "Polis teşkilatı ile mayfa arasında geçen çetin bir savaşı anlatan filmde,polis teşkilatı içine sızan adamların ve mafya içerisine sızan polislerin en iyi pozisyonlara kadar geldiğini görüyoruz.Her iki tarafında içlerinde köstebek olduğunu öğrenmeleri sonucu, yıllarca eğitilen adamların hayatı tehlikeye girer.", 151);
                Movie movie5 = new Movie("Gladiator", "Eski bir Romalı general, ailesini öldüren ve onu köleliğe gönderen yozlaşmış imparatordan intikam almak için yola koyulur.", 155);
                Movie movie6 = new Movie("The Shawshank Redemption", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", 142);
                Movie movie7 = new Movie("Back to the Future", "Marty McFly, a 17-year-old high school student, is accidentally sent 30 years into the past in a time-traveling DeLorean invented by his close friend, the maverick scientist Doc Brown.", 114);
                Movie movie8 = new Movie("Forrest Gump", "Forrest Gump, while not intelligent, has accidentally been present at many historic moments, but his true love, Jenny Curran, eludes him.", 142);
                Movie movie9 = new Movie("Fight Club", "An insomniac office worker, looking for a way to change his life, crosses paths with a devil-may-care soap maker, forming an underground fight club that evolves into something much, much more.", 140);
                Movie movie10 = new Movie("The Lion King", "Lion cub and future king Simba searches for his identity. His eagerness to please others and penchant for testing his boundaries sometimes gets him into trouble.", 90);
                Movie movie11 = new Movie("Green Book", "A working-class Italian-American bouncer becomes the driver of an African-American classical pianist on a tour of venues through the 1960s American South.", 129);
                Movie movie12 = new Movie("The Hateful Eight", "In the dead of a Wyoming winter, a bounty hunter and his prisoner find shelter in a cabin currently inhabited by a collection of nefarious characters.", 187);
                Movie movie13 = new Movie("John Wick 1", "John karısını kaybettikten sonra tek başına bir kenara çekilip sakin hayatını yaşama kararı alır. Günün birinde çok sevdiği arabası hırsızlar tarafından kaçırılır ve arabayı çalan kişi ise bir Rus Mafyasının oğludur. Fakat genç çocuğun bilmediği bir şey vardır ve babası John Wick’i oldukça iyi tanımaktadır. Çünkü John Wick zamanının en iyi ve en tehlikeli tetikçilerinden biridir. Karısına aşık olduktan sonra elini ayağını her şeyden çeken John emekliliğini sakin bir şekilde geçirmek isterken tüm bu olaylar olur ve üstüne üstlük arabasını çalan, karısından geriye kalan tek şeyi, köpeğini de öldürmüştür. John Wick artık bu işin peşini bırakmayacaktır…", 101);
                Movie movie14 = new Movie("John Wick 2", "John Wick her ne kadar düşmanlarını yok edip emekliliğine dönüp köpeği ile birlikte sakin bir hayata geri dönmek istese de, başına gelen olaylar sonrası kendisinden istenenler bir türlü peşini bırakmayacaktır. Bu kez daha zorlu bir olayın içine girmek zorunda kalarak mücadele edecektir…", 122);
                Movie movie15 = new Movie("John Wick 3", "John Wick artık firari ve başına 14 milyon dolarlık ödül koyulmuş bir kaçaktır. Onun kellesini alabilmek için tüm katiller seferber olacaktır. Continental’in kesinlikle çiğnenmemesi gereken kuralını çiğneyen John Wick, Winston tarafından her ne kadar sevilse de Winston’a başka şans bırakmamış ve Continental üyeliğini sonlandırmak zorunda kalmıştır. Fakat Winston yine de John’a 1 saat boyunca kimseden saldırı almayacağına dair söz vermiştir ve bu süreyi çok iyi değerlendirmelidir.", 121);

                Movie.movieList.Add(movie1);
                Movie.movieList.Add(movie2);
                Movie.movieList.Add(movie3);
                Movie.movieList.Add(movie4);
                Movie.movieList.Add(movie5);
                Movie.movieList.Add(movie6);
                Movie.movieList.Add(movie7);
                Movie.movieList.Add(movie8);
                Movie.movieList.Add(movie9);
                Movie.movieList.Add(movie10);
                Movie.movieList.Add(movie11);
                Movie.movieList.Add(movie12);
                Movie.movieList.Add(movie13);
                Movie.movieList.Add(movie14);
                Movie.movieList.Add(movie15);
                foreach (Movie m in Movie.movieList)
                {
                    context.Movies.Add(m);
                }
                context.SaveChanges();
            }
            if (!context.Categories.Any())
            {
                Category category1 = new Category("Drama");
                Category category2 = new Category("War");
                Category category3 = new Category("Music");
                Category category4 = new Category("Action");
                Category category5 = new Category("Adventure");
                Category category6 = new Category("Crime");
                Category category7 = new Category("Thriller");
                Category category8 = new Category("Animation");
                Category category9 = new Category("Sci-Fi");
                Category category10 = new Category("Mystery");
                Category category11 = new Category("Biography");
                Category category12 = new Category("Comedy");

                Category.categoryList.Add(category1);
                Category.categoryList.Add(category2);
                Category.categoryList.Add(category3);
                Category.categoryList.Add(category4);
                Category.categoryList.Add(category5);
                Category.categoryList.Add(category6);
                Category.categoryList.Add(category7);
                Category.categoryList.Add(category8);
                Category.categoryList.Add(category9);
                Category.categoryList.Add(category10);
                Category.categoryList.Add(category11);
                Category.categoryList.Add(category12);
                foreach (Category c in Category.categoryList)
                {
                    context.Categories.Add(c);
                }
                context.SaveChanges();
            }
            if (!context.MoviesCategories.Any())
            {
                MoviesCategory moviesCategories1 = new MoviesCategory(1, 1);
                MoviesCategory moviesCategories2 = new MoviesCategory(1, 8);
                MoviesCategory moviesCategories3 = new MoviesCategory(1, 2);
                MoviesCategory moviesCategories4 = new MoviesCategory(2, 2);
                MoviesCategory moviesCategories5 = new MoviesCategory(3, 1);
                MoviesCategory moviesCategories6 = new MoviesCategory(3, 3);
                MoviesCategory moviesCategories7 = new MoviesCategory(4, 4);
                MoviesCategory moviesCategories8 = new MoviesCategory(4, 5);
                MoviesCategory moviesCategories9 = new MoviesCategory(4, 1);
                MoviesCategory moviesCategories10 = new MoviesCategory(5, 1);
                MoviesCategory moviesCategories11 = new MoviesCategory(5, 6);
                MoviesCategory moviesCategories12 = new MoviesCategory(5, 7);
                MoviesCategory moviesCategories13 = new MoviesCategory(6, 1);
                MoviesCategory moviesCategories14 = new MoviesCategory(6, 6);
                MoviesCategory moviesCategories15 = new MoviesCategory(7, 5);
                MoviesCategory moviesCategories16 = new MoviesCategory(7, 9);
                MoviesCategory moviesCategories17 = new MoviesCategory(7, 12);
                MoviesCategory moviesCategories18 = new MoviesCategory(8, 1);
                MoviesCategory moviesCategories19 = new MoviesCategory(8, 12);
                MoviesCategory moviesCategories20 = new MoviesCategory(9, 1);
                MoviesCategory moviesCategories21 = new MoviesCategory(10, 1);
                MoviesCategory moviesCategories22 = new MoviesCategory(10, 5);
                MoviesCategory moviesCategories23 = new MoviesCategory(10, 8);
                MoviesCategory moviesCategories24 = new MoviesCategory(11, 1);
                MoviesCategory moviesCategories25 = new MoviesCategory(11, 11);
                MoviesCategory moviesCategories26 = new MoviesCategory(11, 12);
                MoviesCategory moviesCategories27 = new MoviesCategory(12, 1);
                MoviesCategory moviesCategories28 = new MoviesCategory(12, 6);
                MoviesCategory moviesCategories29 = new MoviesCategory(12, 10);
                MoviesCategory moviesCategories30 = new MoviesCategory(13, 4);
                MoviesCategory moviesCategories31 = new MoviesCategory(13, 6);
                MoviesCategory moviesCategories32 = new MoviesCategory(13, 7);
                MoviesCategory moviesCategories33 = new MoviesCategory(14, 4);
                MoviesCategory moviesCategories34 = new MoviesCategory(14, 6);
                MoviesCategory moviesCategories35 = new MoviesCategory(14, 7);
                MoviesCategory moviesCategories36 = new MoviesCategory(15, 4);
                MoviesCategory moviesCategories37 = new MoviesCategory(15, 6);
                MoviesCategory moviesCategories38 = new MoviesCategory(15, 7);


                context.MoviesCategories.Add(moviesCategories1);
                context.MoviesCategories.Add(moviesCategories2);
                context.MoviesCategories.Add(moviesCategories3);
                context.MoviesCategories.Add(moviesCategories4);
                context.MoviesCategories.Add(moviesCategories5);
                context.MoviesCategories.Add(moviesCategories6);
                context.MoviesCategories.Add(moviesCategories7);
                context.MoviesCategories.Add(moviesCategories8);
                context.MoviesCategories.Add(moviesCategories9);
                context.MoviesCategories.Add(moviesCategories10);
                context.MoviesCategories.Add(moviesCategories11);
                context.MoviesCategories.Add(moviesCategories12);
                context.MoviesCategories.Add(moviesCategories13);
                context.MoviesCategories.Add(moviesCategories14);
                context.MoviesCategories.Add(moviesCategories15);
                context.MoviesCategories.Add(moviesCategories16);
                context.MoviesCategories.Add(moviesCategories17);
                context.MoviesCategories.Add(moviesCategories18);
                context.MoviesCategories.Add(moviesCategories19);
                context.MoviesCategories.Add(moviesCategories20);
                context.MoviesCategories.Add(moviesCategories21);
                context.MoviesCategories.Add(moviesCategories22);
                context.MoviesCategories.Add(moviesCategories23);
                context.MoviesCategories.Add(moviesCategories24);
                context.MoviesCategories.Add(moviesCategories25);
                context.MoviesCategories.Add(moviesCategories26);
                context.MoviesCategories.Add(moviesCategories27);
                context.MoviesCategories.Add(moviesCategories28);
                context.MoviesCategories.Add(moviesCategories29);
                context.MoviesCategories.Add(moviesCategories30);
                context.MoviesCategories.Add(moviesCategories31);
                context.MoviesCategories.Add(moviesCategories32);
                context.MoviesCategories.Add(moviesCategories33);
                context.MoviesCategories.Add(moviesCategories34);
                context.MoviesCategories.Add(moviesCategories35);
                context.MoviesCategories.Add(moviesCategories36);
                context.MoviesCategories.Add(moviesCategories37);
                context.MoviesCategories.Add(moviesCategories38);

                context.SaveChanges();
            }
            if (!context.Saloons.Any())
            {
                Saloon salon1 = new Saloon("A", 40);
                Saloon salon2 = new Saloon("B", 58);
                Saloon salon3 = new Saloon("C", 94);
                Saloon salon4 = new Saloon("D", 72);
                Saloon.saloonList.Add(salon1);
                Saloon.saloonList.Add(salon2);
                Saloon.saloonList.Add(salon3);
                Saloon.saloonList.Add(salon4);
                foreach (Saloon s in Saloon.saloonList)
                {
                    context.Saloons.Add(s);
                }
                context.SaveChanges();
            }
            if (!context.Sessions.Any())
            {
                Session session1 = new Session("11:00");
                Session session2 = new Session("12:00");
                Session session3 = new Session("13:00");
                Session session4 = new Session("14:00");
                Session session5 = new Session("15:00");
                Session session6 = new Session("16:00");
                Session session7 = new Session("17:00");
                Session session8 = new Session("18:30");
                Session session9 = new Session("20:00");
                Session session10 = new Session("21:30");
                Session.sessionList.Add(session1);
                Session.sessionList.Add(session2);
                Session.sessionList.Add(session3);
                Session.sessionList.Add(session4);
                Session.sessionList.Add(session5);
                Session.sessionList.Add(session6);
                Session.sessionList.Add(session7);
                Session.sessionList.Add(session8);
                Session.sessionList.Add(session9);
                Session.sessionList.Add(session10);

                foreach (Session s in Session.sessionList)
                {
                    context.Sessions.Add(s);
                }
                context.SaveChanges();
            }
            if (!context.Weeks.Any())
            {
                DateTime week1start = new DateTime(2016, 08, 08);
                DateTime week1end = new DateTime(2016, 08, 14);
                DateTime week2start = new DateTime(2016, 08, 15);
                DateTime week2end = new DateTime(2016, 08, 22);
                DateTime week3start = new DateTime(2016, 08, 23);
                DateTime week3end = new DateTime(2016, 08, 29);
                DateTime week4start = new DateTime(2016, 08, 30);
                DateTime week4end = new DateTime(2016, 09, 05);
                DateTime week5start = new DateTime(2016, 09, 06);
                DateTime week5end = new DateTime(2016, 09, 13);

                Week week1 = new Week("W1", week1start, week1end);
                Week week2 = new Week("W2", week2start, week2end);
                Week week3 = new Week("W3", week3start, week3end);
                Week week4 = new Week("W4", week4start, week4end);
                Week week5 = new Week("W5", week5start, week5end);
                Week.weekList.Add(week1);
                Week.weekList.Add(week2);
                Week.weekList.Add(week3);
                Week.weekList.Add(week4);
                Week.weekList.Add(week5);
                foreach (Week w in Week.weekList)
                {
                    context.Weeks.Add(w);
                }
                context.SaveChanges();
            }
            if (!context.Theaters.Any())
            {
                Theater theater1 = new Theater(1, 1, 1, 1);
                Theater theater2 = new Theater(1, 5, 1, 1);
                Theater theater3 = new Theater(1, 8, 1, 1);
                Theater theater4 = new Theater(2, 4, 3, 2);
                Theater theater5 = new Theater(2, 9, 1, 2);
                Theater theater6 = new Theater(2, 2, 1, 2);
                Theater theater7 = new Theater(3, 1, 1, 3);
                Theater theater8 = new Theater(3, 1, 2, 3);
                Theater theater9 = new Theater(3, 6, 4, 3);
                Theater theater10 = new Theater(4, 5, 1, 3);
                Theater theater11 = new Theater(4, 1, 2, 3);
                Theater theater12 = new Theater(4, 10, 4, 3);
                Theater theater13 = new Theater(5, 4, 4, 4);
                Theater theater14 = new Theater(5, 2, 2, 4);
                Theater theater15 = new Theater(5, 8, 3, 4);
                Theater theater16 = new Theater(6, 1, 1, 4);
                Theater theater17 = new Theater(6, 5, 3, 4);
                Theater theater18 = new Theater(6, 7, 2, 4);
                Theater theater19 = new Theater(7, 3, 3, 4);
                Theater theater20 = new Theater(7, 9, 3, 4);
                Theater theater21 = new Theater(8, 1, 1, 5);
                Theater theater22 = new Theater(8, 4, 1, 5);
                Theater theater23 = new Theater(8, 10, 1, 5);
                Theater theater24 = new Theater(9, 2, 2, 5);
                Theater theater25 = new Theater(9, 5, 2, 5);
                Theater theater26 = new Theater(9, 8, 2, 5);
                Theater theater27 = new Theater(10, 3, 3, 5);
                Theater theater28 = new Theater(10, 7, 3, 5);
                Theater theater29 = new Theater(10, 10, 3, 5);
                Theater theater30 = new Theater(11, 1, 4, 5);
                Theater theater31 = new Theater(11, 6, 4, 5);
                Theater theater32 = new Theater(11, 9, 4, 5);
                Theater theater33 = new Theater(12, 1, 2, 1);
                Theater theater34 = new Theater(12, 7, 2, 1);
                Theater theater35 = new Theater(12, 10, 2, 1);
                Theater theater36 = new Theater(13, 6, 3, 1);
                Theater theater37 = new Theater(13, 4, 3, 1);
                Theater theater38 = new Theater(13, 8, 4, 1);
                Theater theater39 = new Theater(14, 1, 2, 2);
                Theater theater40 = new Theater(14, 6, 2, 2);
                Theater theater41 = new Theater(14, 9, 2, 2);
                Theater theater42 = new Theater(15, 2, 4, 2);
                Theater theater43 = new Theater(15, 5, 4, 2);
                Theater theater44 = new Theater(15, 8, 4, 2);

                Theater.theatherList.Add(theater1);
                Theater.theatherList.Add(theater2);
                Theater.theatherList.Add(theater3);
                Theater.theatherList.Add(theater4);
                Theater.theatherList.Add(theater5);
                Theater.theatherList.Add(theater6);
                Theater.theatherList.Add(theater7);
                Theater.theatherList.Add(theater8);
                Theater.theatherList.Add(theater9);
                Theater.theatherList.Add(theater10);
                Theater.theatherList.Add(theater11);
                Theater.theatherList.Add(theater12);
                Theater.theatherList.Add(theater13);
                Theater.theatherList.Add(theater14);
                Theater.theatherList.Add(theater15);
                Theater.theatherList.Add(theater16);
                Theater.theatherList.Add(theater17);
                Theater.theatherList.Add(theater18);
                Theater.theatherList.Add(theater19);
                Theater.theatherList.Add(theater20);
                Theater.theatherList.Add(theater21);
                Theater.theatherList.Add(theater22);
                Theater.theatherList.Add(theater23);
                Theater.theatherList.Add(theater24);
                Theater.theatherList.Add(theater25);
                Theater.theatherList.Add(theater26);
                Theater.theatherList.Add(theater27);
                Theater.theatherList.Add(theater28);
                Theater.theatherList.Add(theater29);
                Theater.theatherList.Add(theater30);
                Theater.theatherList.Add(theater31);
                Theater.theatherList.Add(theater32);
                Theater.theatherList.Add(theater33);
                Theater.theatherList.Add(theater34);
                Theater.theatherList.Add(theater35);
                Theater.theatherList.Add(theater36);
                Theater.theatherList.Add(theater37);
                Theater.theatherList.Add(theater38);
                Theater.theatherList.Add(theater39);
                Theater.theatherList.Add(theater40);
                Theater.theatherList.Add(theater41);
                Theater.theatherList.Add(theater42);
                Theater.theatherList.Add(theater43);
                Theater.theatherList.Add(theater44);

                foreach (Theater t in Theater.theatherList)
                {
                    context.Theaters.Add(t);
                }
                context.SaveChanges();
            }

        }
    }
}
