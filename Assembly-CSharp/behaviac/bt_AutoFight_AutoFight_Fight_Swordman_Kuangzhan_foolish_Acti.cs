﻿using System;

namespace behaviac
{
	// Token: 0x02002362 RID: 9058
	public static class bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action
	{
		// Token: 0x06013031 RID: 77873 RVA: 0x0059F334 File Offset: 0x0059D734
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("AutoFight/AutoFight_Fight_Swordman_Kuangzhan_foolish_Action");
			bt.IsFSM = false;
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(0);
			bt.AddChild(sequence);
			DecoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node1 decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node = new DecoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node1();
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node.SetClassNameString("DecoratorAlwaysSuccess");
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node.SetId(1);
			sequence.AddChild(decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node);
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(2);
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node.AddChild(sequence2);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node6 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node6();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node.SetId(6);
			sequence2.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node7 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node7();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2.SetId(7);
			sequence2.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node8 action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node8();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node.SetId(8);
			sequence2.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node.HasEvents());
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node.SetHasEvents(decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node.HasEvents() | sequence2.HasEvents());
			sequence.SetHasEvents(sequence.HasEvents() | decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node.HasEvents());
			Selector selector = new Selector();
			selector.SetClassNameString("Selector");
			selector.SetId(3);
			sequence.AddChild(selector);
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(4);
			selector.AddChild(sequence3);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3.SetId(5);
			sequence3.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3.HasEvents());
			DecoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node9 decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2 = new DecoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node9();
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2.SetClassNameString("DecoratorAlwaysSuccess");
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2.SetId(9);
			sequence3.AddChild(decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2);
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(10);
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2.AddChild(sequence4);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node11 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node11();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4.SetId(11);
			sequence4.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node12 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node12();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5.SetId(12);
			sequence4.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node13 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node6 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node13();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node6.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node6.SetId(13);
			sequence4.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node6);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node6.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node14 action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2 = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node14();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2.SetId(14);
			sequence4.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2.HasEvents());
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2.SetHasEvents(decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2.HasEvents() | sequence4.HasEvents());
			sequence3.SetHasEvents(sequence3.HasEvents() | decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node2.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence3.HasEvents());
			Sequence sequence5 = new Sequence();
			sequence5.SetClassNameString("Sequence");
			sequence5.SetId(15);
			selector.AddChild(sequence5);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node16 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node7 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node16();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node7.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node7.SetId(16);
			sequence5.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node7);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node7.HasEvents());
			DecoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node17 decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3 = new DecoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node17();
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3.SetClassNameString("DecoratorAlwaysSuccess");
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3.SetId(17);
			sequence5.AddChild(decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3);
			Sequence sequence6 = new Sequence();
			sequence6.SetClassNameString("Sequence");
			sequence6.SetId(18);
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3.AddChild(sequence6);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node19 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node8 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node19();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node8.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node8.SetId(19);
			sequence6.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node8);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node8.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node21 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node9 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node21();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node9.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node9.SetId(21);
			sequence6.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node9);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node9.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node22 action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3 = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node22();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3.SetId(22);
			sequence6.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3.HasEvents());
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3.SetHasEvents(decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3.HasEvents() | sequence6.HasEvents());
			sequence5.SetHasEvents(sequence5.HasEvents() | decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node3.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence5.HasEvents());
			Sequence sequence7 = new Sequence();
			sequence7.SetClassNameString("Sequence");
			sequence7.SetId(20);
			selector.AddChild(sequence7);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node23 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node10 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node23();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node10.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node10.SetId(23);
			sequence7.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node10);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node10.HasEvents());
			DecoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node24 decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4 = new DecoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node24();
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4.SetClassNameString("DecoratorAlwaysSuccess");
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4.SetId(24);
			sequence7.AddChild(decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4);
			Sequence sequence8 = new Sequence();
			sequence8.SetClassNameString("Sequence");
			sequence8.SetId(25);
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4.AddChild(sequence8);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node26 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node11 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node26();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node11.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node11.SetId(26);
			sequence8.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node11);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node11.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node27 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node12 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node27();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node12.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node12.SetId(27);
			sequence8.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node12);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node12.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node28 action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4 = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node28();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4.SetId(28);
			sequence8.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4);
			sequence8.SetHasEvents(sequence8.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4.HasEvents());
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4.SetHasEvents(decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4.HasEvents() | sequence8.HasEvents());
			sequence7.SetHasEvents(sequence7.HasEvents() | decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node4.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence7.HasEvents());
			Sequence sequence9 = new Sequence();
			sequence9.SetClassNameString("Sequence");
			sequence9.SetId(29);
			selector.AddChild(sequence9);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node30 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node13 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node30();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node13.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node13.SetId(30);
			sequence9.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node13);
			sequence9.SetHasEvents(sequence9.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node13.HasEvents());
			DecoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node31 decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5 = new DecoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node31();
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5.SetClassNameString("DecoratorAlwaysSuccess");
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5.SetId(31);
			sequence9.AddChild(decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5);
			Sequence sequence10 = new Sequence();
			sequence10.SetClassNameString("Sequence");
			sequence10.SetId(32);
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5.AddChild(sequence10);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node33 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node14 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node33();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node14.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node14.SetId(33);
			sequence10.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node14);
			sequence10.SetHasEvents(sequence10.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node14.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node34 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node15 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node34();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node15.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node15.SetId(34);
			sequence10.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node15);
			sequence10.SetHasEvents(sequence10.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node15.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node35 action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5 = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node35();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5.SetId(35);
			sequence10.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5);
			sequence10.SetHasEvents(sequence10.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5.HasEvents());
			decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5.SetHasEvents(decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5.HasEvents() | sequence10.HasEvents());
			sequence9.SetHasEvents(sequence9.HasEvents() | decoratorAlwaysSuccess_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node5.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence9.HasEvents());
			Sequence sequence11 = new Sequence();
			sequence11.SetClassNameString("Sequence");
			sequence11.SetId(36);
			selector.AddChild(sequence11);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node37 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node16 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node37();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node16.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node16.SetId(37);
			sequence11.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node16);
			sequence11.SetHasEvents(sequence11.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node16.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node38 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node17 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node38();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node17.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node17.SetId(38);
			sequence11.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node17);
			sequence11.SetHasEvents(sequence11.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node17.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node39 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node18 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node39();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node18.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node18.SetId(39);
			sequence11.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node18);
			sequence11.SetHasEvents(sequence11.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node18.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node40 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node19 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node40();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node19.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node19.SetId(40);
			sequence11.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node19);
			sequence11.SetHasEvents(sequence11.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node19.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node41 action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node6 = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node41();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node6.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node6.SetId(41);
			sequence11.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node6);
			sequence11.SetHasEvents(sequence11.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node6.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence11.HasEvents());
			Sequence sequence12 = new Sequence();
			sequence12.SetClassNameString("Sequence");
			sequence12.SetId(42);
			selector.AddChild(sequence12);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node44 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node20 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node44();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node20.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node20.SetId(44);
			sequence12.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node20);
			sequence12.SetHasEvents(sequence12.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node20.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node43 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node21 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node43();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node21.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node21.SetId(43);
			sequence12.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node21);
			sequence12.SetHasEvents(sequence12.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node21.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node45 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node22 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node45();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node22.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node22.SetId(45);
			sequence12.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node22);
			sequence12.SetHasEvents(sequence12.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node22.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node46 action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node7 = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node46();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node7.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node7.SetId(46);
			sequence12.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node7);
			sequence12.SetHasEvents(sequence12.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node7.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence12.HasEvents());
			Sequence sequence13 = new Sequence();
			sequence13.SetClassNameString("Sequence");
			sequence13.SetId(47);
			selector.AddChild(sequence13);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node48 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node23 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node48();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node23.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node23.SetId(48);
			sequence13.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node23);
			sequence13.SetHasEvents(sequence13.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node23.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node49 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node24 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node49();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node24.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node24.SetId(49);
			sequence13.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node24);
			sequence13.SetHasEvents(sequence13.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node24.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node52 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node25 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node52();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node25.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node25.SetId(52);
			sequence13.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node25);
			sequence13.SetHasEvents(sequence13.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node25.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node50 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node26 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node50();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node26.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node26.SetId(50);
			sequence13.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node26);
			sequence13.SetHasEvents(sequence13.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node26.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node51 action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node8 = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node51();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node8.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node8.SetId(51);
			sequence13.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node8);
			sequence13.SetHasEvents(sequence13.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node8.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence13.HasEvents());
			Sequence sequence14 = new Sequence();
			sequence14.SetClassNameString("Sequence");
			sequence14.SetId(53);
			selector.AddChild(sequence14);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node54 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node27 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node54();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node27.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node27.SetId(54);
			sequence14.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node27);
			sequence14.SetHasEvents(sequence14.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node27.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node55 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node28 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node55();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node28.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node28.SetId(55);
			sequence14.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node28);
			sequence14.SetHasEvents(sequence14.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node28.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node56 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node29 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node56();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node29.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node29.SetId(56);
			sequence14.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node29);
			sequence14.SetHasEvents(sequence14.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node29.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node57 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node30 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node57();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node30.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node30.SetId(57);
			sequence14.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node30);
			sequence14.SetHasEvents(sequence14.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node30.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node58 action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node9 = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node58();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node9.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node9.SetId(58);
			sequence14.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node9);
			sequence14.SetHasEvents(sequence14.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node9.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence14.HasEvents());
			Sequence sequence15 = new Sequence();
			sequence15.SetClassNameString("Sequence");
			sequence15.SetId(59);
			selector.AddChild(sequence15);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node60 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node31 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node60();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node31.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node31.SetId(60);
			sequence15.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node31);
			sequence15.SetHasEvents(sequence15.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node31.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node61 condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node32 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node61();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node32.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node32.SetId(61);
			sequence15.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node32);
			sequence15.SetHasEvents(sequence15.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node32.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node64 action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node10 = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node64();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node10.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node10.SetId(64);
			sequence15.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node10);
			sequence15.SetHasEvents(sequence15.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node10.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence15.HasEvents());
			sequence.SetHasEvents(sequence.HasEvents() | selector.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | sequence.HasEvents());
			return true;
		}
	}
}
