namespace BlazorApplication.Data
{
    public class Animal
    {
        public string Name { get; set; }
        public string WildAncestor { get; set; }
        public string PlaceOfDomestication { get; set; }
        public string DomesticationTime { get; set; }

        public static List<Animal> GetAnimals()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal() 
                { 
                    Name = "Собаки", 
                    WildAncestor = "Волк", 
                    PlaceOfDomestication = "Европа, Передняя азия, Северная Азия (Сибирь), Восточная Азия", 
                    DomesticationTime = "15-10"
                },
                new Animal() 
                { 
                    Name = "Овцы", 
                    WildAncestor = "Азиатский муфлон", 
                    PlaceOfDomestication = "Передняя Азия", 
                    DomesticationTime = "10-9"
                },
                new Animal() 
                { 
                    Name = "Козы", 
                    WildAncestor = "Безоаровый козел", 
                    PlaceOfDomestication = "Передняя Азия", 
                    DomesticationTime = "10-9"
                },
                new Animal() 
                { 
                    Name = "Крупный рогатый скот", 
                    WildAncestor = "Тур", 
                    PlaceOfDomestication = "Северная Африка", 
                    DomesticationTime = "8-7"
                },
                new Animal() 
                { 
                    Name = "Свиньи", 
                    WildAncestor = "Дикий кабан", 
                    PlaceOfDomestication = "Евразия", 
                    DomesticationTime = "9-3"
                },
                new Animal() 
                { 
                    Name = "Лошади", 
                    WildAncestor = "Тарпан", 
                    PlaceOfDomestication = "Евразия",
                    DomesticationTime = "6-5"
                },
                new Animal() 
                { 
                    Name = "Верблюды", 
                    WildAncestor = "Дикие верблюды", 
                    PlaceOfDomestication = "Аравийский полуостров, Западная и Средняя Азия", 
                    DomesticationTime = "5,5-5"
                },
                new Animal() 
                { 
                    Name = "Куры", 
                    WildAncestor = "Банкивские и красные куры", 
                    PlaceOfDomestication = "Южная и Юго-Восточная Азия", 
                    DomesticationTime = "6-5"
                },
                new Animal() 
                { 
                    Name = "Кошки",
                    WildAncestor = "Дикая кошка", 
                    PlaceOfDomestication = "Северная Африка (Египет), Ближний и Средний Восток", 
                    DomesticationTime = "Не менее 5"
                },
                new Animal() 
                { 
                    Name = "Медоносные пчелы", 
                    WildAncestor = "Дикие пчелы", 
                    PlaceOfDomestication = "Тропики и субтропики", 
                    DomesticationTime = "Менее 5"
                },
                new Animal() 
                { 
                    Name = "Гуси", 
                    WildAncestor = "Серый гусь", 
                    PlaceOfDomestication = "Евразия, Северо-Восточная Африка", 
                    DomesticationTime = "5-4"
                },
                new Animal() 
                { 
                    Name = "Утки", 
                    WildAncestor = "Дикая утка", 
                    PlaceOfDomestication = "Европа, Азия (Китай)", 
                    DomesticationTime = "4-3"
                },
                new Animal() 
                { 
                    Name = "Индюки", 
                    WildAncestor = "Дикий индюк",
                    PlaceOfDomestication = "Северная Мексика",
                    DomesticationTime = "2"
                },
            };
            return animals;
        }
    }
}
