using CsvHelper.Configuration;

namespace ConsoleAppFileSystem
{
    class ProcessedOrderMap : ClassMap<ProcessedOrder>
    {
        public ProcessedOrderMap()
        {
            AutoMap();

            Map(m => m.Customer).Name("CustomerNumber");
            Map(m => m.Amount).Name("Quantity").TypeConverter<RomanTypeConverter>();
        }
    }
}
