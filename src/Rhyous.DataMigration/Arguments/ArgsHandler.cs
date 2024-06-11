using Rhyous.DataMigration.Salesforce.Interfaces;
using Rhyous.SimpleArgs;

namespace Rhyous.DataMigration
{
    /// <summary>
    /// A class that implements IArgumentsHandler where command line
    /// arguments are defined.
    /// 
    /// </summary>
    public sealed class ArgsHandler : ArgsHandlerBase
    {
        public override void InitializeArguments(IArgsManager argsManager)
        {
            Arguments.AddRange(new List<Argument>
            {
                //public string Username { get; }
                //public string Password { get; }
                new Argument
                {
                    Name = nameof(ISalesforceConfig.TokenRequestUrl),
                    ShortName = "T",
                    Description = "The url to authenticate to Salesforce.",
                    Example = "{name}=https://somedomain.tld/some/path",
                    IsRequired = true
                },
                new Argument
                {
                    Name = nameof(ISalesforceConfig.ClientId),
                    ShortName = "C",
                    Description = "The Salesforce client id.",
                    Example = "{name}=abcdefg123",
                    IsRequired = true
                },
                new Argument
                {
                    Name = nameof(ISalesforceConfig.ClientSecret),
                    ShortName = "S",
                    Description = "The Salesforce client secret.",
                    Example = "{name}=abcdefg123",
                    IsRequired = true
                },
                new Argument
                {
                    Name = nameof(ISalesforceConfig.Username),
                    ShortName = "u",
                    Description = "The salesforce username.",
                    Example = "{name}=someuser@somedomain.tld",
                    IsRequired = true
                },
                new Argument
                {
                    Name = nameof(ISalesforceConfig.Password),
                    ShortName = "p",
                    Description = "The salesforce password.",
                    Example = "{name}=someuser@somedomain.tld",
                    IsRequired = true
                },
                new Argument
                {
                    Name = "Account",
                    ShortName = "a",
                    Description = "The account in the prior system.",
                    Example = "{name}=someuser@somedomain.tld"
                },
                new Argument
                {
                    Name = "AccountsFile",
                    ShortName = "f",
                    Description = "The path to a file containing accounts, each account id on a new line, so accounts can be batched.",
                    Example = "{name}=someuser@somedomain.tld"
                },
                new Argument
                {
                    Name = "BatchSize",
                    ShortName = "b",
                    Description = "The number of accounts to process at the same time.",
                    Example = "{name}=10",
                    DefaultValue = 5.ToString()
                },
                new ConfigFileArgument(argsManager)
            });
        }

        public override int MinimumRequiredArgs
        {
            get { return 1; } // At least one argument is required
        }

        public override void HandleArgs(IReadArgs inArgsHandler)
        {
            base.HandleArgs(inArgsHandler);
            Console.WriteLine("I handled the args!!!");
            if (Args.Value("Value") == Args.Get("Value").DefaultValue)
                Console.WriteLine("You left the default value of {0}", Args.Value("Value"));
            else
                Console.WriteLine("You changed the default value to {0}", Args.Value("Value"));
        }
    }
}