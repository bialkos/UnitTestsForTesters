using System;

namespace UnitTestsFortTesters
{
    public class StoreController
    {
        public ActionResult GetStore(int id)
        {
            if (id < 0 )
                throw new ArgumentOutOfRangeException();

            if (id == 0)
                return new NotFound();
            
            return new Ok();
        }        
    }
    
    public class ActionResult { }
    
    public class NotFound : ActionResult { }
 
    public class Ok : ActionResult { }
}