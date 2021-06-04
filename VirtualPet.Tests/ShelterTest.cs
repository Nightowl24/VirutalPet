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
        [Fact]
        public void AdoptPet_Should_Decrease_Pet_List_By_1()
        {
            //Arrange
            Pet mypet = new Pet();
            //Act
            myShelter.AdmitPet(mypet);

            myShelter.AdoptPet(mypet);
            //Assert
            Assert.Empty(myShelter.ShelterPets);


        }

        [Fact]
        public void PlayAll_Should_Interact_With_All_In_Shelter()
        {
            Pet mypet = new Pet();
            myShelter.AdmitPet(mypet);

            myShelter.Playall();

            Assert.Equal(40, myShelter.ShelterPets[0].Health);
        }





        
    }
}
