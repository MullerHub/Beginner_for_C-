using System;

// Classe que representa um nó na lista duplamente encadeada
class Node
{
  public int data; // Valor armazenado no nó
  public Node prev; // Ponteiro para o nó anterior na lista
  public Node next; // Ponteiro para o próximo nó na lista

  // Construtor que cria um novo nó com o valor especificado
  public Node(int value)
  {
    data = value;
    prev = null;
    next = null;
  }
}

// Classe que representa uma lista duplamente encadeada
class DoublyLinkedList
{
  private Node head; // Ponteiro para o primeiro nó na lista
  private Node tail; // Ponteiro para o último nó na lista

  // Construtor que cria uma lista vazia
  public DoublyLinkedList()
  {
    head = null;
    tail = null;
  }

  // Este método adiciona um novo nó ao final da lista
  public void AddNode(int value)
  {
    // Criamos um novo nó com o valor especificado
    Node newNode = new Node(value);

    // Se a lista está vazia, definimos head e tail como o novo nó
    if (head == null)
    {
      head = newNode;
      tail = newNode;
    }
    // Se a lista já contém nós, adicionamos o novo nó ao final da lista
    else
    {
      // Definimos o ponteiro next do último nó (tail) para o novo nó
      tail.next = newNode;
      // Definimos o ponteiro prev do novo nó para o último nó (tail)
      newNode.prev = tail;
      // Atualizamos tail para o novo nó
      tail = newNode;
    }
  }

  // Este método remove o primeiro nó da lista que contém o valor especificado
  public void RemoveNode(int value)
  {
    // Começamos pelo primeiro nó (head)
    Node currentNode = head;

    // Enquanto currentNode não é null, sabemos que ainda não chegamos ao final da lista
    while (currentNode != null)
    {
      // Se encontramos o nó com o valor especificado, precisamos removê-lo da lista
      // Para remover um nó, precisamos atualizar as referências next e prev dos nós adjacentes
      if (currentNode.data == value)
      {
        // Se currentNode é o primeiro nó (head), precisamos atualizar head para o próximo nó (currentNode.next) e atualizar a referência prev do próximo nó para null
        if (currentNode == head)
        {
          head = currentNode.next;
          currentNode.next.prev = null;
        }
        // Se currentNode não é o primeiro nó, atualizamos a referência prev do nó seguinte (currentNode.next) para o nó anterior (currentNode.prev) e a referência next do nó anterior para o nó seguinte (currentNode.next)
        else
        {
          currentNode.prev.next = currentNode.next;
          currentNode.next.prev = currentNode.prev;
        }
        return;
      }

      // Se o nó atual não é o nó a ser removido, precisamos avançar para o próximo nó na lista
      currentNode = currentNode.next;
    }
  }
}

// Este método imprime todos os nós da lista, começando pelo primeiro nó (head)

