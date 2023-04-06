using System;

// Definimos uma classe Node que representa um nó da nossa lista encadeada
class Node
{
  // Cada nó tem um valor inteiro e uma referência para o próximo nó na lista
  public int data;
  public Node next;

  // O construtor cria um novo nó com o valor especificado e define next como null
  public Node(int value)
  {
    data = value;
    next = null;
  }
}

// Definimos uma classe LinkedList que representa a própria lista encadeada
class LinkedList
{
  // A lista começa com um nó vazio
  private Node head;

  // O construtor cria uma lista vazia definindo head como null
  public LinkedList()
  {
    head = null;
  }

  // Este método adiciona um novo nó com o valor especificado ao final da lista
  public void AddNode(int value)
  {
    // Primeiro, criamos um novo nó com o valor especificado
    Node newNode = new Node(value);

    // Se a lista está vazia, head será null e precisamos defini-lo como o novo nó
    if (head == null)
    {
      head = newNode;
      return;
    }

    // Se a lista não está vazia, precisamos percorrer a lista até o final para adicionar o novo nó
    // Começamos pelo primeiro nó (head)
    Node currentNode = head;

    // Enquanto currentNode.next não é null, sabemos que ainda não chegamos ao final da lista
    while (currentNode.next != null)
    {
      // Avançamos currentNode para o próximo nó
      currentNode = currentNode.next;
    }

    // Quando chegamos ao final da lista, definimos o próximo nó como o novo nó que criamos
    currentNode.next = newNode;
  }

  // Este método remove o primeiro nó da lista que contém o valor especificado (se houver)
  public void RemoveNode(int value)
  {
    // Se a lista está vazia, não há nada a remover
    if (head == null)
    {
      return;
    }

    // Se o nó a ser removido é o primeiro nó (head), precisamos atualizar head
    if (head.data == value)
    {
      head = head.next;
      return;
    }

    // Se o nó a ser removido não é o primeiro nó, precisamos percorrer a lista para encontrá-lo
    // Começamos pelo primeiro nó (head)
    Node currentNode = head;

    // Enquanto o próximo nó (currentNode.next) não é null, sabemos que ainda não chegamos ao final da lista
    while (currentNode.next != null)
    {
      // Se o próximo nó contém o valor que queremos remover, atualizamos a referência do nó atual para pular o próximo nó
      if (currentNode.next.data == value)
      {
        currentNode.next = currentNode.next.next;
        return;
      }

      // Avançamos currentNode para o próximo nó
      currentNode = currentNode.next;
    }
  }

  // Este método imprime os valores de todos os nós na lista
  public void PrintList()
  {
    // Começamos pelo primeiro nó (head)
    Node currentNode = head;

    // Enquanto currentNode
  }
}