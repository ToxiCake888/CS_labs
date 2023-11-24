class player
{
    public string Name { get; set; }
    public string Skill { get; set; }
    public int Age { get; set; }
}

class prog
{
    static void Main()
    {
        bool switcher = true;
        List<player> team = new List<player>();
        team.Add(new player { Name = "sasha", Skill = "vratar", Age = 69 });
        team.Add(new player { Name = "anton", Skill = "napadaushii", Age = 10 });
        
        while (switcher==true) {
            
            Console.WriteLine("1.Add player ");
            Console.WriteLine("2.Show team ");
            Console.WriteLine("3.End ");
            Console.WriteLine("4.Find skill ");
            Console.WriteLine("5.Older then 18 ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Name = ");
                        string pname= Console.ReadLine();
                        Console.WriteLine("Age = ");
                        int page = int.Parse(Console.ReadLine());
                        Console.WriteLine("skill = ");
                        string pskill = Console.ReadLine();
                        team.Add(new player {Name=pname , Age=page , Skill=pskill });
                        break;
                    }
                case 2: 
                    {
                        foreach (player player in team)
                        {
                            Console.Write("name = ");
                            Console.WriteLine(player.Name);
                            Console.Write("skill = ");
                            Console.WriteLine(player.Skill);
                            Console.Write("age = ");
                            Console.WriteLine(player.Age);
                            Console.WriteLine(" ");
                        }
                        break;
                    }
                case 3:
                    {
                        switcher = false; 
                        break;
                    }
                case 4:
                    {
                        int amplua_counter =0;
                        Console.WriteLine("Skill = ");
                        string amplua = Console.ReadLine();
                        foreach (player player in team)
                        {
                            if (player.Skill == amplua)
                            {
                                amplua_counter += 1;
                            }
                        }
                        Console.WriteLine("Founded with amplua "+amplua +" : "+ amplua_counter);
                        break;
                    }
                case 5:
                    {
                        int older_then_18 = 0;
                        foreach(player player in team)
                        {
                            if(player.Age >18) 
                            {
                                older_then_18 += 1;
                            }
                        }
                        Console.WriteLine("older then 18: " + older_then_18 + " players");
                        break;
                    }
            }
        }
    }
}