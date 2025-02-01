using System;
using Microsoft.AspNetCore.SignalR;

namespace DietPortions;

public class GroupPortion
{
    public int Quantity {get; set;} = 1;
    required public GroupType FoodType {get; set;}
}

public enum GroupType 
{
    Verduras = 0,
    Frutas,
    Cereales_1,
    Cereales_2,
    Legominosas,
    Animal_1,
    Animal_2,
    Animal_3,
    Animal_4,
    Leche_1,
    Leche_2,
    Leche_3,
    Leche_4,
    Grasas_1,
    Grasas_2,
    Azucares_1,
    Azucares_2,
    Alcohol

}
