using System.Collections.Generic;
using Commander.data;
using Commander.Models;

namespace Commander.Data
{
  public class MockCommonerRepo : ICommanderRepo
  {
    public IEnumerable<Command> GetAppCommands()
    {
      var commands = new List<Command>{
        new Command{Id=0, HowTo="Boil and serve", Line="Boil Water", Platform="Kettle & Pan"},
        new Command{Id=1, HowTo="Cut bread", Line="Get a knife", Platform="Knife & chopping board"},
        new Command{Id=2, HowTo="Make a cup of tea", Line="Place tea in cup", Platform="Kettle & cup"},
      };
      return commands;
    }

    public Command GetCommandById(int id)
    {
      return new Command { Id = 0, HowTo = "Boil and serve", Line = "1", Platform = "Kettle & Pan" };
    }
  }

}