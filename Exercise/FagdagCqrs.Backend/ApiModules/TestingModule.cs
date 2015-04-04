﻿using FagdagCqrs.Backend.Data;
using Nancy;

namespace FagdagCqrs.Backend.ApiModules
{
    public class TestingModule : NancyModule
    {
        public TestingModule() : base("api/testing")
        {
            Post["/dropDatabase"] = parameters =>
            {
                Database.Instance().Drop();
                return HttpStatusCode.OK;
            };
        }
    }
}