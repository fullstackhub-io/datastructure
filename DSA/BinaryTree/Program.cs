BinaryTree.BinaryTree binaryTree = new BinaryTree.BinaryTree();
binaryTree.Insert(50);
binaryTree.Insert(30);
binaryTree.Insert(20);
binaryTree.Insert(40);
binaryTree.Insert(70);
binaryTree.Insert(60);
binaryTree.Insert(80);

Util.WriteDebug("Pre order");
binaryTree.TraversePreOrder();

Util.WriteDebug("In order");
binaryTree.TraverseInOrder();

Util.WriteDebug("Post order");
binaryTree.TraversePostOrder();

Util.WriteDebug($"Tree height: {binaryTree.GetHeight()}");

BinaryTree.BinaryTree binaryTree2 = new BinaryTree.BinaryTree();
binaryTree2.Insert(10);
binaryTree2.Insert(20);
binaryTree2.Insert(61);
binaryTree2.Insert(8);
binaryTree2.Insert(3);
binaryTree2.Insert(40);

Util.WriteDebug($"Two tree equal: {binaryTree.IsEqual(binaryTree2)}");

Util.WriteDebug($"Is Binary search tree: {binaryTree.IsBinarySearchTree()}");