// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by CashOverflow Team
// --------------------------------------------------------


namespace CashOverFlow.Models.Locations
{
    public class Location
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public Country Counrty { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
