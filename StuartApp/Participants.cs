using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuartApp
{
    class Participant
    {
        public string Name
        { get; set; }
        private List<string> teamMembers;

        public Participant(string nameIn)
        {
            Name = nameIn;
            teamMembers = new List<string>();
        }

        public void AddTeamMember(string member)
        {
            teamMembers.Add(member);
        }

        public bool IsTeam() 
        {
            return teamMembers.Count() > 0;
        }
    }

    public class Participants
    {
        Dictionary<string, Participant> participants;
        public Participants()
        {
            participants = new Dictionary<string, Participant>();
        }
        public int GetCount()
        {
            int count = participants.Count;
            return count;
        }
        //Add member
        public bool AddPartipant(string name)
        { 
            bool success = false;
            if (!participants.ContainsKey(name))
            {
                participants.Add(name, new Participant(name));
                success = true;
            }
            return success;
        }
        public bool AddTeamMemberToPartipant(string participantName, string memberName)
        {
            bool success = false;
            if (!participants.ContainsKey(participantName))
            {
                participants[participantName].AddTeamMember(memberName);
                success = true;
            }
            return success;
        }
    }


    class Event
    {
        private string Name
        { get; set; }
        private string EventType
        { get; set; }
        private Dictionary<string, int> participants;

        public Event(string nameIn, string eventType)
        {
            Name = nameIn;
            EventType = eventType;
            participants = new Dictionary<string, int>();
        } 

        public int GetScore(string participant)
        {
            int score = 0;
            participants.TryGetValue(participant, out score);
            return score;
        }
        public bool AddParticipant(string name)
        {
            bool success = false;
            if (!participants.ContainsKey(name))
            {
                participants[name]=0;
                success = true;
            }
            return success;
        }
    }

    class Events
    {
        private Dictionary<string, Event> events;

        public Events()
        {
            events = new Dictionary<string, Event>();
        }

        public bool AddEvent(string name, string eventType)
        {
            bool success = false;
            if (!events.ContainsKey(name))
            {
                events.Add(name, new Event(name, eventType));
                success = true;
            }
            return success;
        }
        public int GetScore(string participant)
        {
            int score = 0;
            foreach(var item in events)
            {
                score += item.Value.GetScore(participant);
            }
            return score;
        }
    }

    class Tournament
    {
        public const int MaxNumberIndividuals = 20;
        public const int MaxNumberTeams = 4;
        public const int MaxNumberTeamMembers = 5;
        public Events individualEvents;
        public Events teamEvents;
        public Participants individuals;
        public Participants teams;
        public Tournament()
        {
            individualEvents = new Events();
            teamEvents = new Events();
            individuals = new Participants();
            teams = new Participants();
        }
    }
}