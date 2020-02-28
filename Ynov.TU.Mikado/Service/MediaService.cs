using Optional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ynov.TU.Mikado.Models;

namespace Ynov.TU.Mikado.Service
{
    public class MediaService
    {
        private const string AlreadyExistMessage = "This media already exist in DB";
        private const string UnknownIdMessage = "This id is unknow in DB";

        //Add Media
        public (bool result, Option<string> errorOption) AddMedia(string name, MediaCategory category) {
            try
            {
#warning TODO Add new Media in db
                return (true, Option.None<string>());
            }
            catch //(AlreadyExistException e)
            {
                return (false, AlreadyExistMessage.Some());
            }
            // catch (UnknownException e) { return (false, UnknownErrorMessage.Some()); } ... 
        }

        //Delete Media
        public (bool result, Option<string> errorOption) DeleteMedia(int id) {
            try
            {
#warning TODO Delete Media in db
                return (true, Option.None<string>());
            }
            catch //(UnknownIdException e)
            {
                return (false, UnknownIdMessage.Some());
            }
            // catch (UnknownException e) { return (false, UnknownErrorMessage.Some()); } ... 
        }
    }
}
