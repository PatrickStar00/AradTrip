﻿using System;

namespace behaviac
{
	// Token: 0x02002151 RID: 8529
	public static class bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action
	{
		// Token: 0x06012C34 RID: 76852 RVA: 0x00583A0C File Offset: 0x00581E0C
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("AutoFight/AutoFight_Fight_Gunman_Manyou_foolish_Action");
			bt.IsFSM = false;
			Selector selector = new Selector();
			selector.SetClassNameString("Selector");
			selector.SetId(0);
			bt.AddChild(selector);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(1);
			selector.AddChild(sequence);
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node2 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node2();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node.SetId(2);
			sequence.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node3 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node2 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node3();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node2.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node2.SetId(3);
			sequence.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node2);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node2.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node4 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node4();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node.SetId(4);
			sequence.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node5 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node2 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node5();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node2.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node2.SetId(5);
			sequence.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node2);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node2.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(6);
			selector.AddChild(sequence2);
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node7 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node3 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node7();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node3.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node3.SetId(7);
			sequence2.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node3);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node3.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node8 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node4 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node8();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node4.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node4.SetId(8);
			sequence2.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node4);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node4.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node9 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node3 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node9();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node3.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node3.SetId(9);
			sequence2.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node3);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node3.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node10 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node4 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node10();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node4.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node4.SetId(10);
			sequence2.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node4);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node4.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence2.HasEvents());
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(11);
			selector.AddChild(sequence3);
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node12 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node5 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node12();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node5.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node5.SetId(12);
			sequence3.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node5);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node5.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node13 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node6 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node13();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node6.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node6.SetId(13);
			sequence3.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node6);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node6.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node14 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node5 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node14();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node5.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node5.SetId(14);
			sequence3.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node5);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node5.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node15 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node6 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node15();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node6.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node6.SetId(15);
			sequence3.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node6);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node6.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence3.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(16);
			selector.AddChild(sequence4);
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node17 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node7 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node17();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node7.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node7.SetId(17);
			sequence4.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node7);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node7.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node18 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node8 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node18();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node8.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node8.SetId(18);
			sequence4.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node8);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node8.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node19 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node7 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node19();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node7.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node7.SetId(19);
			sequence4.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node7);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node7.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node20 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node8 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node20();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node8.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node8.SetId(20);
			sequence4.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node8);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node8.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence4.HasEvents());
			Sequence sequence5 = new Sequence();
			sequence5.SetClassNameString("Sequence");
			sequence5.SetId(21);
			selector.AddChild(sequence5);
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node22 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node9 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node22();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node9.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node9.SetId(22);
			sequence5.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node9);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node9.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node23 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node10 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node23();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node10.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node10.SetId(23);
			sequence5.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node10);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node10.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node24 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node9 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node24();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node9.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node9.SetId(24);
			sequence5.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node9);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node9.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node25 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node10 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node25();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node10.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node10.SetId(25);
			sequence5.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node10);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node10.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence5.HasEvents());
			Sequence sequence6 = new Sequence();
			sequence6.SetClassNameString("Sequence");
			sequence6.SetId(26);
			selector.AddChild(sequence6);
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node27 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node11 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node27();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node11.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node11.SetId(27);
			sequence6.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node11);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node11.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node28 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node12 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node28();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node12.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node12.SetId(28);
			sequence6.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node12);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node12.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node29 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node11 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node29();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node11.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node11.SetId(29);
			sequence6.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node11);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node11.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node30 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node12 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node30();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node12.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node12.SetId(30);
			sequence6.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node12);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node12.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence6.HasEvents());
			Sequence sequence7 = new Sequence();
			sequence7.SetClassNameString("Sequence");
			sequence7.SetId(31);
			selector.AddChild(sequence7);
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node32 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node13 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node32();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node13.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node13.SetId(32);
			sequence7.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node13);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node13.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node33 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node14 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node33();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node14.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node14.SetId(33);
			sequence7.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node14);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node14.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node34 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node13 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node34();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node13.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node13.SetId(34);
			sequence7.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node13);
			sequence7.SetHasEvents(sequence7.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node13.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node35 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node14 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node35();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node14.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node14.SetId(35);
			sequence7.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node14);
			sequence7.SetHasEvents(sequence7.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node14.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence7.HasEvents());
			Sequence sequence8 = new Sequence();
			sequence8.SetClassNameString("Sequence");
			sequence8.SetId(36);
			selector.AddChild(sequence8);
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node37 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node15 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node37();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node15.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node15.SetId(37);
			sequence8.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node15);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node15.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node38 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node16 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node38();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node16.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node16.SetId(38);
			sequence8.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node16);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node16.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node39 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node15 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node39();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node15.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node15.SetId(39);
			sequence8.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node15);
			sequence8.SetHasEvents(sequence8.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node15.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node40 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node16 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node40();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node16.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node16.SetId(40);
			sequence8.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node16);
			sequence8.SetHasEvents(sequence8.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node16.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence8.HasEvents());
			Sequence sequence9 = new Sequence();
			sequence9.SetClassNameString("Sequence");
			sequence9.SetId(41);
			selector.AddChild(sequence9);
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node42 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node17 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node42();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node17.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node17.SetId(42);
			sequence9.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node17);
			sequence9.SetHasEvents(sequence9.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node17.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node43 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node18 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node43();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node18.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node18.SetId(43);
			sequence9.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node18);
			sequence9.SetHasEvents(sequence9.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node18.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node44 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node17 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node44();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node17.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node17.SetId(44);
			sequence9.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node17);
			sequence9.SetHasEvents(sequence9.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node17.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node45 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node18 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node45();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node18.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node18.SetId(45);
			sequence9.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node18);
			sequence9.SetHasEvents(sequence9.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node18.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence9.HasEvents());
			Sequence sequence10 = new Sequence();
			sequence10.SetClassNameString("Sequence");
			sequence10.SetId(46);
			selector.AddChild(sequence10);
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node47 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node19 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node47();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node19.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node19.SetId(47);
			sequence10.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node19);
			sequence10.SetHasEvents(sequence10.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node19.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node48 condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node20 = new Condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node48();
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node20.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node20.SetId(48);
			sequence10.AddChild(condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node20);
			sequence10.SetHasEvents(sequence10.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node20.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node50 action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node19 = new Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node50();
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node19.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node19.SetId(50);
			sequence10.AddChild(action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node19);
			sequence10.SetHasEvents(sequence10.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node19.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence10.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | selector.HasEvents());
			return true;
		}
	}
}
