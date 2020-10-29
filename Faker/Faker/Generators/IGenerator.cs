using System;

namespace Faker.Faker.Generators
{
    public interface IGenerator
    {
        Object Generate();

        Type GetGenerationType();
    }
}