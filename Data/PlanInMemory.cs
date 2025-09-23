namespace Data;
using Domain.Model;

public static class PlanInMemory
{
        public static List<Plan> Planes;

        static PlanInMemory()
        {
            Planes = new List<Plan>
            {
                new Plan("plan 1", 1, 1)
                
            };
        }
 
}