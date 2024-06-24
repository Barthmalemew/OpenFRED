namespace OpenFRED.Entities;

public class Participant
{
   public int Id { get; set; }
   public string name { get; set; }
   public string expectedOutput { get; set; }
   public string actualOutput { get; set; }
   public string consentForm { get; set; }
}