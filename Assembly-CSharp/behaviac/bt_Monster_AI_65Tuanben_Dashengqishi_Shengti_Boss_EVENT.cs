﻿using System;

namespace behaviac
{
	// Token: 0x02002EAB RID: 11947
	public static class bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT
	{
		// Token: 0x06014631 RID: 83505 RVA: 0x00621158 File Offset: 0x0061F558
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/65Tuanben/Dashengqishi_Shengti_Boss_EVENT");
			bt.IsFSM = false;
			Parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node16 parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node = new Parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node16();
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetClassNameString("Parallel");
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetId(16);
			bt.AddChild(parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(7);
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.AddChild(sequence);
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node9 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node9();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetId(9);
			sequence.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node8 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node8();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetId(8);
			sequence.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.HasEvents());
			Assignment_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node10 assignment_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node = new Assignment_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node10();
			assignment_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetClassNameString("Assignment");
			assignment_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetId(10);
			sequence.AddChild(assignment_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node);
			sequence.SetHasEvents(sequence.HasEvents() | assignment_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.HasEvents());
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.HasEvents() | sequence.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(25);
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.AddChild(sequence2);
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node3 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node3();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2.SetId(3);
			sequence2.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2.HasEvents());
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node36 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node3 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node36();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node3.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node3.SetId(36);
			sequence2.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node3);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node3.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node28 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node28();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2.SetId(28);
			sequence2.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node4 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node3 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node4();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node3.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node3.SetId(4);
			sequence2.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node3);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node3.HasEvents());
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.HasEvents() | sequence2.HasEvents());
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(0);
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.AddChild(sequence3);
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node1 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node4 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node1();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node4.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node4.SetId(1);
			sequence3.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node4);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node4.HasEvents());
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node5 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node5.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node5.SetId(2);
			sequence3.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node5);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node5.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node5 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node4 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node5();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node4.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node4.SetId(5);
			sequence3.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node4);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node4.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node6 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node5 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node6();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node5.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node5.SetId(6);
			sequence3.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node5);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node5.HasEvents());
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.HasEvents() | sequence3.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(11);
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.AddChild(sequence4);
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node64 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node6 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node64();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node6.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node6.SetId(64);
			sequence4.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node6);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node6.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node13 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node6 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node13();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node6.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node6.SetId(13);
			sequence4.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node6);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node6.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node261 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node7 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node261();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node7.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node7.SetId(261);
			sequence4.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node7);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node7.HasEvents());
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.HasEvents() | sequence4.HasEvents());
			Sequence sequence5 = new Sequence();
			sequence5.SetClassNameString("Sequence");
			sequence5.SetId(14);
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.AddChild(sequence5);
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node20 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node7 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node20();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node7.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node7.SetId(20);
			sequence5.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node7);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node7.HasEvents());
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node15 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node8 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node15();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node8.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node8.SetId(15);
			sequence5.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node8);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node8.HasEvents());
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node17 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node9 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node17();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node9.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node9.SetId(17);
			sequence5.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node9);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node9.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node18 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node8 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node18();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node8.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node8.SetId(18);
			sequence5.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node8);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node8.HasEvents());
			Assignment_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node19 assignment_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2 = new Assignment_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node19();
			assignment_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2.SetClassNameString("Assignment");
			assignment_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2.SetId(19);
			sequence5.AddChild(assignment_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2);
			sequence5.SetHasEvents(sequence5.HasEvents() | assignment_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node2.HasEvents());
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.HasEvents() | sequence5.HasEvents());
			Sequence sequence6 = new Sequence();
			sequence6.SetClassNameString("Sequence");
			sequence6.SetId(21);
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.AddChild(sequence6);
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node22 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node10 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node22();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node10.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node10.SetId(22);
			sequence6.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node10);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node10.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node23 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node9 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node23();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node9.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node9.SetId(23);
			sequence6.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node9);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node9.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node29 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node10 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node29();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node10.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node10.SetId(29);
			sequence6.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node10);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node10.HasEvents());
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.HasEvents() | sequence6.HasEvents());
			Sequence sequence7 = new Sequence();
			sequence7.SetClassNameString("Sequence");
			sequence7.SetId(24);
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.AddChild(sequence7);
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node26 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node11 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node26();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node11.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node11.SetId(26);
			sequence7.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node11);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node11.HasEvents());
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node27 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node12 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node27();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node12.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node12.SetId(27);
			sequence7.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node12);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node12.HasEvents());
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node79 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node13 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node79();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node13.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node13.SetId(79);
			sequence7.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node13);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node13.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node30 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node11 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node30();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node11.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node11.SetId(30);
			sequence7.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node11);
			sequence7.SetHasEvents(sequence7.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node11.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node31 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node12 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node31();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node12.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node12.SetId(31);
			sequence7.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node12);
			sequence7.SetHasEvents(sequence7.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node12.HasEvents());
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.HasEvents() | sequence7.HasEvents());
			Sequence sequence8 = new Sequence();
			sequence8.SetClassNameString("Sequence");
			sequence8.SetId(40);
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.AddChild(sequence8);
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node41 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node14 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node41();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node14.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node14.SetId(41);
			sequence8.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node14);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node14.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node42 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node13 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node42();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node13.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node13.SetId(42);
			sequence8.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node13);
			sequence8.SetHasEvents(sequence8.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node13.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node43 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node14 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node43();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node14.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node14.SetId(43);
			sequence8.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node14);
			sequence8.SetHasEvents(sequence8.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node14.HasEvents());
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.HasEvents() | sequence8.HasEvents());
			Sequence sequence9 = new Sequence();
			sequence9.SetClassNameString("Sequence");
			sequence9.SetId(78);
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.AddChild(sequence9);
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node32 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node15 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node32();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node15.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node15.SetId(32);
			sequence9.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node15);
			sequence9.SetHasEvents(sequence9.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node15.HasEvents());
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node258 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node16 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node258();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node16.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node16.SetId(258);
			sequence9.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node16);
			sequence9.SetHasEvents(sequence9.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node16.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node33 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node15 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node33();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node15.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node15.SetId(33);
			sequence9.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node15);
			sequence9.SetHasEvents(sequence9.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node15.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node34 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node16 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node34();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node16.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node16.SetId(34);
			sequence9.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node16);
			sequence9.SetHasEvents(sequence9.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node16.HasEvents());
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.HasEvents() | sequence9.HasEvents());
			Sequence sequence10 = new Sequence();
			sequence10.SetClassNameString("Sequence");
			sequence10.SetId(12);
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.AddChild(sequence10);
			Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node35 condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node17 = new Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node35();
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node17.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node17.SetId(35);
			sequence10.AddChild(condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node17);
			sequence10.SetHasEvents(sequence10.HasEvents() | condition_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node17.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node260 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node17 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node260();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node17.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node17.SetId(260);
			sequence10.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node17);
			sequence10.SetHasEvents(sequence10.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node17.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node39 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node18 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node39();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node18.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node18.SetId(39);
			sequence10.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node18);
			sequence10.SetHasEvents(sequence10.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node18.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node37 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node19 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node37();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node19.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node19.SetId(37);
			sequence10.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node19);
			sequence10.SetHasEvents(sequence10.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node19.HasEvents());
			Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node38 action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node20 = new Action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node38();
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node20.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node20.SetId(38);
			sequence10.AddChild(action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node20);
			sequence10.SetHasEvents(sequence10.HasEvents() | action_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node20.HasEvents());
			parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.HasEvents() | sequence10.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | parallel_bt_Monster_AI_65Tuanben_Dashengqishi_Shengti_Boss_EVENT_node.HasEvents());
			return true;
		}
	}
}
