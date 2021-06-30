using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuartApp
{
    class UI
    {
        public void MenuMain(ref Tournament tournament)
        {
            for (bool kill = false; kill == false;)
            {
                Console.WriteLine("\n" +
                    "Please only type numbers\n" +
                    "--------------------------------------\n" +
                    "1 - alter teams and participants\n" +
                    "2 - alter events and scoring\n" +
                    "3 - add teams/individuals to event\n" +
                    "--------------------------------------\n" +
                    "\n" +
                    "4 - Exit\n" +
                    "\n" +
                    "\n" +
                    "Awaiting input...");
                string menNav = Console.ReadLine();
                switch (menNav)
                {
                    case "1":
                        MenuParticipant(ref tournament);
                        break;
                    case "2":
                        MenuEvents(ref tournament);
                        break;
                    case "3":
                        MenuAddParticipantToEvent(ref tournament);
                        break;
                    case "4":
                        kill = true;
                        break;
                }
            }
        }
        public void MenuParticipant(ref Tournament tournament)
        {
            for (bool menKill = false; menKill == false; )
            {
            Console.WriteLine("\n" +
                    "\n" +
                    "--------------------------------------\n" +
                    "Teams\n" +
                    "\n" +
                    "1 - create new team\n" +
                    "\n" +
                    "--------------------------------------\n" +
                    "Individuals\n" +
                    "\n" +
                    "2 - add individual\n" +
                    "\n" +
                    "--------------------------------------\n" +
                    "3 - back\n" +
                    "\n" +
                    "\n" +
                    "Awaiting input...");
                string menNav = Console.ReadLine();
                switch (menNav)
                {
                    case "1":
                        {
                            if (tournament.teams.GetCount() < Tournament.MaxNumberTeams)
                            {
                                string teamName = "";
                                for (bool addTeamName = false; addTeamName == false;)
                                {
                                    Console.WriteLine("\n\nInput team...\n");
                                    teamName = Console.ReadLine();
                                    if (!tournament.teams.AddPartipant(teamName))
                                    {
                                        Console.WriteLine("\n\nError - team exists\n");
                                    }
                                    else
                                    {
                                        addTeamName = true;
                                    }
                                }
                                for (int addMember = 1; addMember <= Tournament.MaxNumberTeamMembers; ++addMember)
                                {
                                    Console.WriteLine("\n\nInput member " + addMember + "\n");
                                    string memberName = Console.ReadLine();
                                    tournament.teams.AddTeamMemberToPartipant(teamName, memberName);
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\n\nError - teams at max capacity (" + Tournament.MaxNumberTeams + ")");
                                break;
                            }
                        }
                    case "2":
                        {
                            if (tournament.individuals.GetCount() < Tournament.MaxNumberIndividuals)
                            {
                                Console.WriteLine("\n\nInput name...\n");
                                string name = Console.ReadLine();
                                if (!tournament.individuals.AddPartipant(name))
                                {
                                    Console.WriteLine("\n\nError - name exists\n");
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\n\nError - individual competitors at max capacity (" + Tournament.MaxNumberIndividuals + ")");
                                break;
                            }
                        }
                    case "3":
                        {
                            menKill = true;
                            break;
                        }
                }
            }
        }


        public void MenuEvents(ref Tournament tournament)
        {
            for (bool menKill = false; menKill == false;)
            {
                Console.WriteLine("\n" +
                    "\n" +
                    "--------------------------------------\n" +
                    "Add event\n"+
                    "1 - add team event\n"+
                    "2 - add individual event\n"+
                    "--------------------------------------\n" +
                    "3 - alter event scoring\n" +
                    "--------------------------------------\n" +
                    "4 - exit\n" +
                    "\n" +
                    "\n" +
                    "Awaiting input...");
                string menNav = Console.ReadLine();
                switch (menNav)
                {
                    case "1":
                        {
                            Console.WriteLine("\n\nInput event...\n");
                            string name = Console.ReadLine();
                            Console.WriteLine("\n\nInput type...\n");
                            string eventType = Console.ReadLine();
                            if (!tournament.teamEvents.AddEvent(name, eventType))
                            {
                                Console.WriteLine("\n\nError - event exists\n");
                            }
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("\n\nInput event...\n");
                            string name = Console.ReadLine();
                            Console.WriteLine("\n\nInput type...\n");
                            string eventType = Console.ReadLine();
                            if (!tournament.individualEvents.AddEvent(name, eventType))
                            {
                                Console.WriteLine("\n\nError - event exists\n");
                            }
                            break;
                        }
                    case "3":
                        {
                            //todo
                            break;
                        }
                    case "4":
                        {
                            menKill = true;
                            break;
                        }
                }
            }
        }

        public void MenuAddParticipantToEvent(ref Tournament tournament)
        {
            Console.WriteLine("\n" +
                "\n" +
                "\n" +
                "--------------------------------------\n" +
                "1 - add to individual event\n" +
                "2 - add to team event\n" +
                "--------------------------------------\n" +
                "3 - exit\n" +
                "\n" +
                "\n" +
                "Awaiting input...");
            string menNav = Console.ReadLine();
            switch (menNav)
            {
                case "1":
                    {

                        break;
                    }
            }
        }
    }
}
