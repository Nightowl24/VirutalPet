using Xunit;

namespace VirtualPet.Tests
{
    public class ShelterTest

    {
        public Shelter myShelter;
        public ShelterTest()
        {
            myShelter = new Shelter();
        }
        [Fact]
        public void AdmitPet_Should_Increase_Pet_List_By_1()
        {
            //arrange




            //Act
            myShelter.AdmitPet(new Pet());

            //Assert
            Assert.Single(myShelter.ShelterPets);
        }
        public void AdoptPet_Should_Decrease_Pet_List_By_1()
        {
            //Arrange
            Pet mypet = new Pet();
            myShelter.AdmitPet(mypet);

            myShelter.AdoptPet(mypet); 


        }
    }
}
