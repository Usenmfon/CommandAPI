using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Cook Afang Soup", Line="Periwinkle and meat", Platform="Pot"},
                new Command{Id=2, HowTo="Slice Salad", Line="Get a knife", Platform="Pan"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="return ticket", Line="call the police", Platform="Police station"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}