using GamerHQ_Models.UserModels;
using GamerHQ_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GamerHQ.Controllers
{
    [Authorize]
    [RoutePrefix("api/User")]
    public class StarController : ApiController
    {
        private bool SetStarState(int userId, bool newState)
        {
            // Create the service
            var service = new UserService();

            // Get the note
            var detail = service.GetUserById(userId);

            // Create the NoteEdit model instance with the new star state
            var updatedUser =
                new UserEdit
                {
                    UserID = detail.UserID,
                    Name = detail.Name,
                    GamerTag = detail.GamerTag,
                    Email = detail.Email,
                    Age = detail.Age,
                    WantsCrossplay = newState
                };

            // Return a value indicating whether the update succeeded
            return service.UpdateUser(updatedUser);
        }

        [Route("{id}/Star")]
        [HttpPut]
        public bool ToggleStarOn(int id) => SetStarState(id, true);

        [Route("{id}/Star")]
        [HttpDelete]
        public bool ToggleStarOff(int id) => SetStarState(id, false);
    }
}

