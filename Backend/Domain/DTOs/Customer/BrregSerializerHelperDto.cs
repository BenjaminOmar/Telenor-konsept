namespace Domain.DTOs.Customer;

public class BrregSerializerHelperDto
{
    public class BrregApiResponse
    {
        public Embedded _embedded { get; set; }
    }

    public class Embedded
    {
        public List<Enhet> enheter { get; set; }
    }

    public class Enhet
    {
        public string organisasjonsnummer { get; set; }
        public string navn { get; set; }
        
        public Forretningsadresse forretningsadresse { get; set; }
    }
    
    public class Forretningsadresse
    {
        public string Land { get; set; }
        public string Landkode { get; set; }
        public string Postnummer { get; set; }
        public string Poststed { get; set; }
        public List<string> Adresse { get; set; }
        public string Kommune { get; set; }
        public string Kommunenummer { get; set; }
    }
}