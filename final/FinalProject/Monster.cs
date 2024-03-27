using System.ComponentModel.DataAnnotations.Schema;

public class Monster : Entity
{
  public string Description { get; set; }

 public Monster(string name,int hitPoints, string description, int attack, int personalDefence) :
  base(name, hitPoints, attack, personalDefence)
  {
    Description = description;
  }


  public override int GiveDamage(){

      return Attack;

  }

  public override void TakeDamage(int damageTaken){
    int potentialDamage = damageTaken - PersonalDefence;
    if (potentialDamage > 0){

        HitPoints -= potentialDamage;
    }
    
    
  }
}