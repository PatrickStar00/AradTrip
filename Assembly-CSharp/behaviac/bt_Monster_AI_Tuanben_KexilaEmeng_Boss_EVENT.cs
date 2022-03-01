﻿using System;

namespace behaviac
{
	// Token: 0x02003A11 RID: 14865
	public static class bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT
	{
		// Token: 0x06015BEF RID: 89071 RVA: 0x006910B4 File Offset: 0x0068F4B4
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/Tuanben/KexilaEmeng_Boss_EVENT");
			bt.IsFSM = false;
			Parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node0 parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node = new Parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node0();
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.SetClassNameString("Parallel");
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.SetId(0);
			bt.AddChild(parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(6);
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.AddChild(sequence);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node26 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node26();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.SetId(26);
			sequence.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node39 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node39();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.SetId(39);
			sequence.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node15 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node15();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3.SetId(15);
			sequence.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node13 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node13();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.SetId(13);
			sequence.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.HasEvents());
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.HasEvents() | sequence.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(5);
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.AddChild(sequence2);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node1 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node4 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node1();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node4.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node4.SetId(1);
			sequence2.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node4);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node4.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node93 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node93();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.SetId(93);
			sequence2.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.HasEvents());
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.HasEvents() | sequence2.HasEvents());
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(86);
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.AddChild(sequence3);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node88 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node5 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node88();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node5.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node5.SetId(88);
			sequence3.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node5);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node5.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node8 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node6 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node8();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node6.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node6.SetId(8);
			sequence3.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node6);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node6.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3.SetId(2);
			sequence3.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3.HasEvents());
			Assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node91 assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node = new Assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node91();
			assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.SetClassNameString("Assignment");
			assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.SetId(91);
			sequence3.AddChild(assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node);
			sequence3.SetHasEvents(sequence3.HasEvents() | assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.HasEvents());
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.HasEvents() | sequence3.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(3);
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.AddChild(sequence4);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node4 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node7 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node4();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node7.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node7.SetId(4);
			sequence4.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node7);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node7.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node7 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node8 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node7();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node8.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node8.SetId(7);
			sequence4.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node8);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node8.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node9 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node4 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node9();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node4.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node4.SetId(9);
			sequence4.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node4);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node4.HasEvents());
			Assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node10 assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2 = new Assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node10();
			assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.SetClassNameString("Assignment");
			assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.SetId(10);
			sequence4.AddChild(assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2);
			sequence4.SetHasEvents(sequence4.HasEvents() | assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.HasEvents());
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.HasEvents() | sequence4.HasEvents());
			Sequence sequence5 = new Sequence();
			sequence5.SetClassNameString("Sequence");
			sequence5.SetId(11);
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.AddChild(sequence5);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node12 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node9 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node12();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node9.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node9.SetId(12);
			sequence5.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node9);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node9.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node14 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node10 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node14();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node10.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node10.SetId(14);
			sequence5.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node10);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node10.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node16 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node5 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node16();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node5.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node5.SetId(16);
			sequence5.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node5);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node5.HasEvents());
			Assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node17 assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3 = new Assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node17();
			assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3.SetClassNameString("Assignment");
			assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3.SetId(17);
			sequence5.AddChild(assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3);
			sequence5.SetHasEvents(sequence5.HasEvents() | assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node3.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node18 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node6 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node18();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node6.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node6.SetId(18);
			sequence5.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node6);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node6.HasEvents());
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.HasEvents() | sequence5.HasEvents());
			Parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node21 parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2 = new Parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node21();
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.SetClassNameString("Parallel");
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.SetId(21);
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.AddChild(parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2);
			Sequence sequence6 = new Sequence();
			sequence6.SetClassNameString("Sequence");
			sequence6.SetId(19);
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.AddChild(sequence6);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node20 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node11 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node20();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node11.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node11.SetId(20);
			sequence6.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node11);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node11.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node29 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node7 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node29();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node7.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node7.SetId(29);
			sequence6.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node7);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node7.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node28 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node8 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node28();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node8.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node8.SetId(28);
			sequence6.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node8);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node8.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node22 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node9 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node22();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node9.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node9.SetId(22);
			sequence6.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node9);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node9.HasEvents());
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.SetHasEvents(parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.HasEvents() | sequence6.HasEvents());
			Sequence sequence7 = new Sequence();
			sequence7.SetClassNameString("Sequence");
			sequence7.SetId(23);
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.AddChild(sequence7);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node25 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node12 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node25();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node12.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node12.SetId(25);
			sequence7.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node12);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node12.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node24 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node10 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node24();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node10.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node10.SetId(24);
			sequence7.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node10);
			sequence7.SetHasEvents(sequence7.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node10.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node27 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node11 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node27();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node11.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node11.SetId(27);
			sequence7.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node11);
			sequence7.SetHasEvents(sequence7.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node11.HasEvents());
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.SetHasEvents(parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.HasEvents() | sequence7.HasEvents());
			parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.SetHasEvents(parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.HasEvents() | parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node2.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | parallel_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_EVENT_node.HasEvents());
			return true;
		}
	}
}
