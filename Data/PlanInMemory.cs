namespace Data;
using Domain.Model;

public static class PlanInMemory
{
        public static List<Plan> Planes;

        static PlanInMemory()
        {
            Planes = new List<Plan>
            {
                new Plan( 1 , "Plan 2025",1),
                new Plan( 1 , "Plan 2026",2),
                new Plan( 1 , "Plan 2027",3),
                
            };
        }
 
}