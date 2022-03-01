﻿using System;

namespace behaviac
{
	// Token: 0x020039F4 RID: 14836
	public static class bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION
	{
		// Token: 0x06015BB8 RID: 89016 RVA: 0x0068FE64 File Offset: 0x0068E264
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/Tuanben/KexilaEmeng_Boss_ACTION");
			bt.IsFSM = false;
			Selector selector = new Selector();
			selector.SetClassNameString("Selector");
			selector.SetId(3);
			bt.AddChild(selector);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(44);
			selector.AddChild(sequence);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node45 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node45();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.SetId(45);
			sequence.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node46 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node46();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2.SetId(46);
			sequence.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node47 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node47();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.SetId(47);
			sequence.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.HasEvents());
			Assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node48 assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node = new Assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node48();
			assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.SetClassNameString("Assignment");
			assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.SetId(48);
			sequence.AddChild(assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node);
			sequence.SetHasEvents(sequence.HasEvents() | assignment_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(38);
			selector.AddChild(sequence2);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node39 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node3 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node39();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node3.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node3.SetId(39);
			sequence2.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node3);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node3.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node85 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node4 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node85();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node4.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node4.SetId(85);
			sequence2.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node4);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node4.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node98 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node5 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node98();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node5.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node5.SetId(98);
			sequence2.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node5);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node5.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node56 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node56();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2.SetId(56);
			sequence2.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node40 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node3 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node40();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node3.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node3.SetId(40);
			sequence2.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node3);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node3.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence2.HasEvents());
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(30);
			selector.AddChild(sequence3);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node31 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node6 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node31();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node6.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node6.SetId(31);
			sequence3.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node6);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node6.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node32 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node7 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node32();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node7.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node7.SetId(32);
			sequence3.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node7);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node7.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node36 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node4 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node36();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node4.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node4.SetId(36);
			sequence3.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node4);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node4.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence3.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(25);
			selector.AddChild(sequence4);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node37 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node8 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node37();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node8.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node8.SetId(37);
			sequence4.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node8);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node8.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node26 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node9 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node26();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node9.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node9.SetId(26);
			sequence4.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node9);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node9.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node5 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node10 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node5();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node10.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node10.SetId(5);
			sequence4.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node10);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node10.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node27 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node11 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node27();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node11.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node11.SetId(27);
			sequence4.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node11);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node11.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node28 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node5 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node28();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node5.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node5.SetId(28);
			sequence4.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node5);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node5.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence4.HasEvents());
			Selector selector2 = new Selector();
			selector2.SetClassNameString("Selector");
			selector2.SetId(0);
			selector.AddChild(selector2);
			Selector selector3 = new Selector();
			selector3.SetClassNameString("Selector");
			selector3.SetId(2);
			selector2.AddChild(selector3);
			Sequence sequence5 = new Sequence();
			sequence5.SetClassNameString("Sequence");
			sequence5.SetId(16);
			selector3.AddChild(sequence5);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node58 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node12 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node58();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node12.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node12.SetId(58);
			sequence5.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node12);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node12.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node17 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node13 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node17();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node13.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node13.SetId(17);
			sequence5.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node13);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node13.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node18 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node6 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node18();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node6.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node6.SetId(18);
			sequence5.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node6);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node6.HasEvents());
			selector3.SetHasEvents(selector3.HasEvents() | sequence5.HasEvents());
			Sequence sequence6 = new Sequence();
			sequence6.SetClassNameString("Sequence");
			sequence6.SetId(4);
			selector3.AddChild(sequence6);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node6 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node14 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node6();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node14.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node14.SetId(6);
			sequence6.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node14);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node14.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node7 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node15 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node7();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node15.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node15.SetId(7);
			sequence6.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node15);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node15.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node9 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node7 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node9();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node7.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node7.SetId(9);
			sequence6.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node7);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node7.HasEvents());
			selector3.SetHasEvents(selector3.HasEvents() | sequence6.HasEvents());
			Sequence sequence7 = new Sequence();
			sequence7.SetClassNameString("Sequence");
			sequence7.SetId(33);
			selector3.AddChild(sequence7);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node29 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node16 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node29();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node16.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node16.SetId(29);
			sequence7.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node16);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node16.HasEvents());
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node35 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node17 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node35();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node17.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node17.SetId(35);
			sequence7.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node17);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node17.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node34 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node8 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node34();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node8.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node8.SetId(34);
			sequence7.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node8);
			sequence7.SetHasEvents(sequence7.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node8.HasEvents());
			selector3.SetHasEvents(selector3.HasEvents() | sequence7.HasEvents());
			Sequence sequence8 = new Sequence();
			sequence8.SetClassNameString("Sequence");
			sequence8.SetId(13);
			selector3.AddChild(sequence8);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node14 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node18 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node14();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node18.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node18.SetId(14);
			sequence8.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node18);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node18.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node15 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node9 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node15();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node9.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node9.SetId(15);
			sequence8.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node9);
			sequence8.SetHasEvents(sequence8.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node9.HasEvents());
			selector3.SetHasEvents(selector3.HasEvents() | sequence8.HasEvents());
			selector2.SetHasEvents(selector2.HasEvents() | selector3.HasEvents());
			Selector selector4 = new Selector();
			selector4.SetClassNameString("Selector");
			selector4.SetId(1);
			selector2.AddChild(selector4);
			Sequence sequence9 = new Sequence();
			sequence9.SetClassNameString("Sequence");
			sequence9.SetId(10);
			selector4.AddChild(sequence9);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node11 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node19 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node11();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node19.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node19.SetId(11);
			sequence9.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node19);
			sequence9.SetHasEvents(sequence9.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node19.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node12 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node10 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node12();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node10.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node10.SetId(12);
			sequence9.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node10);
			sequence9.SetHasEvents(sequence9.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node10.HasEvents());
			selector4.SetHasEvents(selector4.HasEvents() | sequence9.HasEvents());
			SelectorProbability_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node42 selectorProbability_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node = new SelectorProbability_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node42();
			selectorProbability_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.SetClassNameString("SelectorProbability");
			selectorProbability_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.SetId(42);
			selectorProbability_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.Initialize("Self.BTAgent::Action_GenRandom()");
			selector4.AddChild(selectorProbability_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node);
			DecoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node41 decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node = new DecoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node41();
			decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.SetClassNameString("DecoratorWeight");
			decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.SetId(41);
			selectorProbability_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.AddChild(decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node);
			Sequence sequence10 = new Sequence();
			sequence10.SetClassNameString("Sequence");
			sequence10.SetId(19);
			decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.AddChild(sequence10);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node20 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node20 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node20();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node20.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node20.SetId(20);
			sequence10.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node20);
			sequence10.SetHasEvents(sequence10.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node20.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node21 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node11 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node21();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node11.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node11.SetId(21);
			sequence10.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node11);
			sequence10.SetHasEvents(sequence10.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node11.HasEvents());
			decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.SetHasEvents(decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.HasEvents() | sequence10.HasEvents());
			selectorProbability_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.SetHasEvents(selectorProbability_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.HasEvents() | decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.HasEvents());
			DecoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node43 decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2 = new DecoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node43();
			decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2.SetClassNameString("DecoratorWeight");
			decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2.SetId(43);
			selectorProbability_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.AddChild(decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2);
			Sequence sequence11 = new Sequence();
			sequence11.SetClassNameString("Sequence");
			sequence11.SetId(22);
			decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2.AddChild(sequence11);
			Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node23 condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node21 = new Condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node23();
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node21.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node21.SetId(23);
			sequence11.AddChild(condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node21);
			sequence11.SetHasEvents(sequence11.HasEvents() | condition_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node21.HasEvents());
			Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node24 action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node12 = new Action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node24();
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node12.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node12.SetId(24);
			sequence11.AddChild(action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node12);
			sequence11.SetHasEvents(sequence11.HasEvents() | action_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node12.HasEvents());
			decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2.SetHasEvents(decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2.HasEvents() | sequence11.HasEvents());
			selectorProbability_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.SetHasEvents(selectorProbability_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.HasEvents() | decoratorWeight_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node2.HasEvents());
			selector4.SetHasEvents(selector4.HasEvents() | selectorProbability_bt_Monster_AI_Tuanben_KexilaEmeng_Boss_ACTION_node.HasEvents());
			selector2.SetHasEvents(selector2.HasEvents() | selector4.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | selector2.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | selector.HasEvents());
			return true;
		}
	}
}