using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;


namespace Sample
{
     class Services
{
        private readonly IPrint _repo;
        
        public Services(IPrint repo)
        {
            _repo = repo;
        }
    public void Print(Sample sample)
    {
            _repo.Print(sample);
    }
}
}

