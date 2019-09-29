using CommandLine;

namespace BigBang.Migrator
{
    public class MigrationOptions
    {
        [Option('c', "connection-string", Required = true, HelpText = "Sets the connection string for the Cosmos Instance to migrate")]
        public string ConnectionString { get; set; }

        [Option('f', "file", Required = true, HelpText = "The JSON File used to migrate Cosmos. Must also be the location of stored procedures.")]
        public string FileLocation { get; set; }

        [Option('t', "update-throughput", Required = false, HelpText = "When set to false it does not update the throughput", Default = true)]
        public bool UpdateDBThroughput { get; set; }
    }
}
