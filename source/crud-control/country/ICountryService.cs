using Gfk.WorldSystem.Countries;

namespace Gfk.WorldSystem.CrudControl.Countries
{
   public interface ICountryService
   {
      ICountry Create();

      void AddAlphaCodes(string code2, string code3);
   }
}