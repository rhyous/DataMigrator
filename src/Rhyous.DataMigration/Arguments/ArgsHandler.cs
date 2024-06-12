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
                    Description = "The url to authenticate to Salesforce. Usually https://login.salesforce.com/services/oauth2/token for production and https://test.salesforce.com/services/oauth2/token for sandboxes.",
                    Example = "{name}=https://login.salesforce.com/services/oauth2/token",
                    DefaultValue = "https://login.salesforce.com/services/oauth2/token",
                    IsRequired = false // Because it has a default
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
                    Description = "The account in the prior system. Either Account or AccountsFile must be provided.",
                    Example = "{name}=someuser@somedomain.tld",
                    Group = 1
                },
                new Argument
                {
                    Name = "AccountsFile",
                    ShortName = "f",
                    Description = "The path to a file containing accounts, each account id on a new line, so accounts can be batched. Either Account or AccountsFile must be provided.",
                    Example = "{name}=someuser@somedomain.tld",
                    CustomValidation = (value) => File.Exists(value),
                    Group = 1
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
        }
    }
}