namespace Demos.Classes
{
    public ref struct PeopleObject
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public AddressStruct AddressPeople {get;set;}
    }
    public struct  AddressStruct
    {        
        public int Number { get; set; }
        public string Address { get; set; }
        
        public string  ZipCode { get; set; }
        public string City {get;set;}
        /*
        Span<int> NumberAddress {get;set;}
        */
    }
    public interface Data
    {
        int Number{get;set;}
        string Address{get;set;}
    }
}
