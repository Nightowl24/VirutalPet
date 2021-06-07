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
            myShelter.AdmitPet(mypet);

            //Act
            myShelter.AdoptPet(mypet);

            //Assert
            Assert.Empty(myShelter.ShelterPets);
        }

        [Fact]
        public void PlayAll_Should_Interact_With_All_In_Shelter()
        {
            Pet mypet = new Pet();
            myShelter.AdmitPet(mypet);

            myShelter.PlayAll();

            Assert.Equal(40, myShelter.ShelterPets[0].Health);
        }

        [Fact]
        public void PetList_Should_List_All_Pets_In_Shelter()
        {
            //Arrange
            Pet mypet = new Pet();
            myShelter.AdmitPet(mypet);

            //Act
            myShelter.PetList();

            //Assert
            Assert.Single(myShelter.ShelterPets);
        }

        [Fact]
        public void GetPet_Should_Select_A_Pet_From_The_List_To_Interact_With()
        {
            //Arrange
            Pet expectedPet = new Pet { Name = "Barry" };
            myShelter.AdmitPet(new Pet {Name = "Molly"});
            myShelter.AdmitPet(expectedPet);

            //Act
            Pet result = myShelter.GetPet("barry");

            //Assert
            Assert.Equal(expectedPet, result);
        }
    }
}