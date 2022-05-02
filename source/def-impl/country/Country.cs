namespace Gfk.WorldSystem.Countries
{
   internal class Country
      : ICountry
   {
      public int Id { get; }
      public string Code2 { get; }
      public string Code3 { get; }

      #region Creation
      public Country(int id, 
                     string code2, string code3)
      {
         Id = id;
         Code2 = code2;
         Code3 = code3;
      }
      #endregion
   }
}