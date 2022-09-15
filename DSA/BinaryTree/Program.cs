BinaryTree.BinaryTree binaryTree = new BinaryTree.BinaryTree();
binaryTree.Insert(10);
binaryTree.Insert(20);
binaryTree.Insert(6);
binaryTree.Insert(8);
binaryTree.Insert(3);
binaryTree.Insert(40);

Util.WriteDebug("Pre order");
binaryTree.TraversePreOrder();

Util.WriteDebug("In order");
binaryTree.TraverseInOrder();

Util.WriteDebug("Post order");
binaryTree.TraversePostOrder();

Util.WriteDebug($"Tree height: {binaryTree.GetHeight()}");