﻿using System;

namespace behaviac
{
	// Token: 0x020034CF RID: 13519
	public static class bt_Monster_AI_Heisedadi_Kongbu_Event
	{
		// Token: 0x060151E4 RID: 86500 RVA: 0x0065C978 File Offset: 0x0065AD78
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/Heisedadi/Kongbu_Event");
			bt.IsFSM = false;
			Parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node1 parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node = new Parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node1();
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetClassNameString("Parallel");
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetId(1);
			bt.AddChild(parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(12);
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.AddChild(sequence);
			Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node13 action_bt_Monster_AI_Heisedadi_Kongbu_Event_node = new Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node13();
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetClassNameString("Action");
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetId(13);
			sequence.AddChild(action_bt_Monster_AI_Heisedadi_Kongbu_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Heisedadi_Kongbu_Event_node.HasEvents());
			Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node0 action_bt_Monster_AI_Heisedadi_Kongbu_Event_node2 = new Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node0();
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node2.SetClassNameString("Action");
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node2.SetId(0);
			sequence.AddChild(action_bt_Monster_AI_Heisedadi_Kongbu_Event_node2);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Heisedadi_Kongbu_Event_node2.HasEvents());
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetHasEvents(parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.HasEvents() | sequence.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(2);
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.AddChild(sequence2);
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node6 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node6();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetId(6);
			sequence2.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node.HasEvents());
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node5 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node2 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node5();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node2.SetId(5);
			sequence2.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node2.HasEvents());
			Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node10 action_bt_Monster_AI_Heisedadi_Kongbu_Event_node3 = new Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node10();
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node3.SetClassNameString("Action");
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node3.SetId(10);
			sequence2.AddChild(action_bt_Monster_AI_Heisedadi_Kongbu_Event_node3);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_Heisedadi_Kongbu_Event_node3.HasEvents());
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node3 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node3 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node3();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node3.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node3.SetId(3);
			sequence2.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node3);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node3.HasEvents());
			Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node8 action_bt_Monster_AI_Heisedadi_Kongbu_Event_node4 = new Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node8();
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node4.SetClassNameString("Action");
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node4.SetId(8);
			sequence2.AddChild(action_bt_Monster_AI_Heisedadi_Kongbu_Event_node4);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_Heisedadi_Kongbu_Event_node4.HasEvents());
			Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node9 action_bt_Monster_AI_Heisedadi_Kongbu_Event_node5 = new Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node9();
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node5.SetClassNameString("Action");
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node5.SetId(9);
			sequence2.AddChild(action_bt_Monster_AI_Heisedadi_Kongbu_Event_node5);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_Heisedadi_Kongbu_Event_node5.HasEvents());
			Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node11 action_bt_Monster_AI_Heisedadi_Kongbu_Event_node6 = new Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node11();
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node6.SetClassNameString("Action");
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node6.SetId(11);
			sequence2.AddChild(action_bt_Monster_AI_Heisedadi_Kongbu_Event_node6);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_Heisedadi_Kongbu_Event_node6.HasEvents());
			Assignment_bt_Monster_AI_Heisedadi_Kongbu_Event_node7 assignment_bt_Monster_AI_Heisedadi_Kongbu_Event_node = new Assignment_bt_Monster_AI_Heisedadi_Kongbu_Event_node7();
			assignment_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetClassNameString("Assignment");
			assignment_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetId(7);
			sequence2.AddChild(assignment_bt_Monster_AI_Heisedadi_Kongbu_Event_node);
			sequence2.SetHasEvents(sequence2.HasEvents() | assignment_bt_Monster_AI_Heisedadi_Kongbu_Event_node.HasEvents());
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetHasEvents(parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.HasEvents() | sequence2.HasEvents());
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(15);
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.AddChild(sequence3);
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node16 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node4 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node16();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node4.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node4.SetId(16);
			sequence3.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node4);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node4.HasEvents());
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node18 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node5 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node18();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node5.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node5.SetId(18);
			sequence3.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node5);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node5.HasEvents());
			Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node14 action_bt_Monster_AI_Heisedadi_Kongbu_Event_node7 = new Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node14();
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node7.SetClassNameString("Action");
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node7.SetId(14);
			sequence3.AddChild(action_bt_Monster_AI_Heisedadi_Kongbu_Event_node7);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_Heisedadi_Kongbu_Event_node7.HasEvents());
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetHasEvents(parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.HasEvents() | sequence3.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(17);
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.AddChild(sequence4);
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node19 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node6 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node19();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node6.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node6.SetId(19);
			sequence4.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node6);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node6.HasEvents());
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node30 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node7 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node30();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node7.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node7.SetId(30);
			sequence4.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node7);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node7.HasEvents());
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node20 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node8 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node20();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node8.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node8.SetId(20);
			sequence4.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node8);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node8.HasEvents());
			Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node21 action_bt_Monster_AI_Heisedadi_Kongbu_Event_node8 = new Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node21();
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node8.SetClassNameString("Action");
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node8.SetId(21);
			sequence4.AddChild(action_bt_Monster_AI_Heisedadi_Kongbu_Event_node8);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_Heisedadi_Kongbu_Event_node8.HasEvents());
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetHasEvents(parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.HasEvents() | sequence4.HasEvents());
			Sequence sequence5 = new Sequence();
			sequence5.SetClassNameString("Sequence");
			sequence5.SetId(22);
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.AddChild(sequence5);
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node23 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node9 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node23();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node9.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node9.SetId(23);
			sequence5.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node9);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node9.HasEvents());
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node45 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node10 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node45();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node10.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node10.SetId(45);
			sequence5.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node10);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node10.HasEvents());
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node44 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node11 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node44();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node11.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node11.SetId(44);
			sequence5.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node11);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node11.HasEvents());
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node24 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node12 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node24();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node12.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node12.SetId(24);
			sequence5.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node12);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node12.HasEvents());
			Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node38 action_bt_Monster_AI_Heisedadi_Kongbu_Event_node9 = new Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node38();
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node9.SetClassNameString("Action");
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node9.SetId(38);
			sequence5.AddChild(action_bt_Monster_AI_Heisedadi_Kongbu_Event_node9);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_Monster_AI_Heisedadi_Kongbu_Event_node9.HasEvents());
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetHasEvents(parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.HasEvents() | sequence5.HasEvents());
			Sequence sequence6 = new Sequence();
			sequence6.SetClassNameString("Sequence");
			sequence6.SetId(26);
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.AddChild(sequence6);
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node27 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node13 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node27();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node13.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node13.SetId(27);
			sequence6.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node13);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node13.HasEvents());
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node28 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node14 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node28();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node14.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node14.SetId(28);
			sequence6.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node14);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node14.HasEvents());
			Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node37 action_bt_Monster_AI_Heisedadi_Kongbu_Event_node10 = new Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node37();
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node10.SetClassNameString("Action");
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node10.SetId(37);
			sequence6.AddChild(action_bt_Monster_AI_Heisedadi_Kongbu_Event_node10);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_Monster_AI_Heisedadi_Kongbu_Event_node10.HasEvents());
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetHasEvents(parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.HasEvents() | sequence6.HasEvents());
			Sequence sequence7 = new Sequence();
			sequence7.SetClassNameString("Sequence");
			sequence7.SetId(46);
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.AddChild(sequence7);
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node47 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node15 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node47();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node15.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node15.SetId(47);
			sequence7.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node15);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node15.HasEvents());
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node48 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node16 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node48();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node16.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node16.SetId(48);
			sequence7.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node16);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node16.HasEvents());
			Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node49 action_bt_Monster_AI_Heisedadi_Kongbu_Event_node11 = new Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node49();
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node11.SetClassNameString("Action");
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node11.SetId(49);
			sequence7.AddChild(action_bt_Monster_AI_Heisedadi_Kongbu_Event_node11);
			sequence7.SetHasEvents(sequence7.HasEvents() | action_bt_Monster_AI_Heisedadi_Kongbu_Event_node11.HasEvents());
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetHasEvents(parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.HasEvents() | sequence7.HasEvents());
			Sequence sequence8 = new Sequence();
			sequence8.SetClassNameString("Sequence");
			sequence8.SetId(25);
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.AddChild(sequence8);
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node31 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node17 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node31();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node17.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node17.SetId(31);
			sequence8.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node17);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node17.HasEvents());
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node35 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node18 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node35();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node18.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node18.SetId(35);
			sequence8.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node18);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node18.HasEvents());
			Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node32 action_bt_Monster_AI_Heisedadi_Kongbu_Event_node12 = new Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node32();
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node12.SetClassNameString("Action");
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node12.SetId(32);
			sequence8.AddChild(action_bt_Monster_AI_Heisedadi_Kongbu_Event_node12);
			sequence8.SetHasEvents(sequence8.HasEvents() | action_bt_Monster_AI_Heisedadi_Kongbu_Event_node12.HasEvents());
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetHasEvents(parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.HasEvents() | sequence8.HasEvents());
			Sequence sequence9 = new Sequence();
			sequence9.SetClassNameString("Sequence");
			sequence9.SetId(33);
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.AddChild(sequence9);
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node36 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node19 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node36();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node19.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node19.SetId(36);
			sequence9.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node19);
			sequence9.SetHasEvents(sequence9.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node19.HasEvents());
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node41 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node20 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node41();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node20.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node20.SetId(41);
			sequence9.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node20);
			sequence9.SetHasEvents(sequence9.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node20.HasEvents());
			Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node39 action_bt_Monster_AI_Heisedadi_Kongbu_Event_node13 = new Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node39();
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node13.SetClassNameString("Action");
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node13.SetId(39);
			sequence9.AddChild(action_bt_Monster_AI_Heisedadi_Kongbu_Event_node13);
			sequence9.SetHasEvents(sequence9.HasEvents() | action_bt_Monster_AI_Heisedadi_Kongbu_Event_node13.HasEvents());
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetHasEvents(parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.HasEvents() | sequence9.HasEvents());
			Sequence sequence10 = new Sequence();
			sequence10.SetClassNameString("Sequence");
			sequence10.SetId(29);
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.AddChild(sequence10);
			Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node34 condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node21 = new Condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node34();
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node21.SetClassNameString("Condition");
			condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node21.SetId(34);
			sequence10.AddChild(condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node21);
			sequence10.SetHasEvents(sequence10.HasEvents() | condition_bt_Monster_AI_Heisedadi_Kongbu_Event_node21.HasEvents());
			Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node40 action_bt_Monster_AI_Heisedadi_Kongbu_Event_node14 = new Action_bt_Monster_AI_Heisedadi_Kongbu_Event_node40();
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node14.SetClassNameString("Action");
			action_bt_Monster_AI_Heisedadi_Kongbu_Event_node14.SetId(40);
			sequence10.AddChild(action_bt_Monster_AI_Heisedadi_Kongbu_Event_node14);
			sequence10.SetHasEvents(sequence10.HasEvents() | action_bt_Monster_AI_Heisedadi_Kongbu_Event_node14.HasEvents());
			parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.SetHasEvents(parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.HasEvents() | sequence10.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | parallel_bt_Monster_AI_Heisedadi_Kongbu_Event_node.HasEvents());
			return true;
		}
	}
}