namespace FactoryPattern;

public interface IFactory<T>
{
    T CreateInstance();
}