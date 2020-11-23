﻿using knapsackEvolutionALgorithm.Service.Common.Utilities;
using knapsackEvolutionALgorithm.Service.Entities;
using knapsackEvolutionALgorithm.Service.Services.LocalServcies.Mutations.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace knapsackEvolutionALgorithm.Service.Services.LocalServcies.Mutations
{
    public class SimpleMutation : IMutationMethod<Individual, Individual>
    {
        private readonly IList<Item> _items;
        private readonly int _knapsackCapacity;

        public SimpleMutation(IList<Item> items, int knapsackCapacity)
        {
            _items = items;
            _knapsackCapacity = knapsackCapacity;
        }
        public Individual HandleMutation(Individual input)
        {
            int point = RandomHelper.CreateRandom(input.Generate.Count());
            input.Generate[point] = (input.Generate[point].Equals(true)) ? false : true;
            return new Individual(input.Generate, _items, _knapsackCapacity);
        }
    }
}
