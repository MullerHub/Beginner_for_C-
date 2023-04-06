// Classe que representa um par chave-valor na hash table
public class KeyValue<TKey, TValue>
{
  public TKey Key { get; set; }
  public TValue Value { get; set; }

  public KeyValue(TKey key, TValue value)
  {
    Key = key;
    Value = value;
  }
}

// Classe que representa uma hash table
public class HashTable<TKey, TValue>
{
  // Array que armazena as listas encadeadas de pares chave-valor
  private List<KeyValue<TKey, TValue>>[] _buckets;

  // Tamanho do array de listas encadeadas
  private int _size;

  // Função hash que mapeia a chave a um índice no array de listas encadeadas
  private int GetBucketIndex(TKey key)
  {
    // Utilizamos o método GetHashCode() do objeto chave para obter um código hash
    int hash = key.GetHashCode();

    // Calculamos o índice utilizando a operação módulo com o tamanho do array de listas encadeadas
    int index = hash % _size;

    return index;
  }

  // Construtor da hash table
  public HashTable(int size)
  {
    _buckets = new List<KeyValue<TKey, TValue>>[size];
    _size = size;
  }

  // Adiciona um par chave-valor na hash table
  public void Add(TKey key, TValue value)
  {
    // Obtemos o índice no array de listas encadeadas
    int index = GetBucketIndex(key);

    // Se a lista encadeada ainda não foi criada para este índice, criamos uma nova lista
    if (_buckets[index] == null)
    {
      _buckets[index] = new List<KeyValue<TKey, TValue>>();
    }

    // Percorremos a lista encadeada para verificar se a chave já existe
    foreach (KeyValue<TKey, TValue> keyValue in _buckets[index])
    {
      // Se a chave já existe, atualizamos o valor correspondente
      if (keyValue.Key.Equals(key))
      {
        keyValue.Value = value;
        return;
      }
    }

    // Se a chave não existe na lista encadeada, adicionamos um novo par chave-valor
    _buckets[index].Add(new KeyValue<TKey, TValue>(key, value));
  }

  // Remove um par chave-valor da hash table
  public void Remove(TKey key)
  {
    // Obtemos o índice no array de listas encadeadas
    int index = GetBucketIndex(key);

    // Se a lista encadeada ainda não foi criada para este índice, não há nada para remover
    if (_buckets[index] == null)
    {
      return;
    }

    // Percorremos a lista encadeada para verificar se a chave existe
    foreach (KeyValue<TKey, TValue> keyValue in _buckets[index])
    {
      // Se a chave existe, removemos o par chave-valor correspondente
      if (keyValue.Key.Equals(key))
      {
        _buckets[index].Remove(keyValue);
        return;
      }
    }
  }

  // Obtém o valor correspondente a uma chave na hash table
  public TValue Get(TKey key);

}