// Classe que representa um nó na Trie
public class TrieNode
{
  // Dicionário que mapeia cada caractere do alfabeto a um nó filho
  private Dictionary<char, TrieNode> _children;

  // Indica se este nó representa o final de uma palavra
  public bool IsEndOfWord { get; set; }

  public TrieNode()
  {
    _children = new Dictionary<char, TrieNode>();
    IsEndOfWord = false;
  }

  // Adiciona uma palavra na Trie
  public void AddWord(string word)
  {
    TrieNode node = this;

    // Percorremos cada caractere da palavra
    foreach (char c in word)
    {
      // Se o caractere não possui um nó filho, criamos um novo nó filho
      if (!node._children.ContainsKey(c))
      {
        node._children[c] = new TrieNode();
      }

      // Avançamos para o próximo nó filho
      node = node._children[c];
    }

    // Marcamos o último nó como final de uma palavra
    node.IsEndOfWord = true;
  }

  // Verifica se uma palavra está na Trie
  public bool ContainsWord(string word)
  {
    TrieNode node = this;

    // Percorremos cada caractere da palavra
    foreach (char c in word)
    {
      // Se o caractere não possui um nó filho, a palavra não está na Trie
      if (!node._children.ContainsKey(c))
      {
        return false;
      }

      // Avançamos para o próximo nó filho
      node = node._children[c];
    }

    // Se chegamos ao final da palavra e o último nó é final de uma palavra, a palavra está na Trie
    return node.IsEndOfWord;
  }

  // Verifica se uma palavra é um prefixo de alguma palavra na Trie
  public bool ContainsPrefix(string prefix)
  {
    TrieNode node = this;

    // Percorremos cada caractere do prefixo
    foreach (char c in prefix)
    {
      // Se o caractere não possui um nó filho, o prefixo não é um prefixo de nenhuma palavra na Trie
      if (!node._children.ContainsKey(c))
      {
        return false;
      }

      // Avançamos para o próximo nó filho
      node = node._children[c];
    }

    // Se chegamos ao final do prefixo, o prefixo é um prefixo de alguma palavra na Trie
    return true;
  }
}

// Classe que representa uma Trie
public class Trie
{
  // Raiz da Trie
  private TrieNode _root;

  public Trie()
  {
    _root = new TrieNode();
  }

  // Adiciona uma palavra na Trie
  public void AddWord(string word)
  {
    _root.AddWord(word);
  }

  // Verifica se uma palavra está na Trie
  public bool ContainsWord(string word)
  {
    return _root.ContainsWord(word);
  }

  // Verifica se uma palavra é um prefixo de alguma palavra na Trie
  public bool ContainsPrefix(string prefix)
  {
    return _root.ContainsPrefix(prefix);
  }
}
