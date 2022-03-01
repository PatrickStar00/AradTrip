﻿using System;

namespace behaviac
{
	// Token: 0x02003190 RID: 12688
	public static class bt_Monster_AI_Chapter9_9_4Kuangsha_Action
	{
		// Token: 0x06014BB7 RID: 84919 RVA: 0x0063DE0C File Offset: 0x0063C20C
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/Chapter9/9-4Kuangsha_Action");
			bt.IsFSM = false;
			Parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node17 parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node = new Parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node17();
			parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetClassNameString("Parallel");
			parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetId(17);
			bt.AddChild(parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node);
			Parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node41 parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2 = new Parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node41();
			parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.SetClassNameString("Parallel");
			parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.SetId(41);
			parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.AddChild(parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(4);
			parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.AddChild(sequence);
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node55 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node55();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetId(55);
			sequence.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node35 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node35();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.SetId(35);
			sequence.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node36 action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node = new Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node36();
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetId(36);
			sequence.AddChild(action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.HasEvents());
			Assignment_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node6 assignment_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node = new Assignment_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node6();
			assignment_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetClassNameString("Assignment");
			assignment_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetId(6);
			sequence.AddChild(assignment_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | assignment_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2 action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2 = new Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2();
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.SetId(2);
			sequence.AddChild(action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.HasEvents());
			parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.SetHasEvents(parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.HasEvents() | sequence.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(5);
			parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.AddChild(sequence2);
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node7 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node3 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node7();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node3.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node3.SetId(7);
			sequence2.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node3);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node3.HasEvents());
			Assignment_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node8 assignment_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2 = new Assignment_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node8();
			assignment_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.SetClassNameString("Assignment");
			assignment_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.SetId(8);
			sequence2.AddChild(assignment_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | assignment_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.HasEvents());
			parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.SetHasEvents(parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.HasEvents() | sequence2.HasEvents());
			parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetHasEvents(parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.HasEvents() | parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.HasEvents());
			SelectorProbability_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node9 selectorProbability_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node = new SelectorProbability_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node9();
			selectorProbability_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetClassNameString("SelectorProbability");
			selectorProbability_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetId(9);
			selectorProbability_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.Initialize("Self.BTAgent::Action_GenRandom()");
			parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.AddChild(selectorProbability_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node);
			DecoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node11 decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node = new DecoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node11();
			decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetClassNameString("DecoratorWeight");
			decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetId(11);
			selectorProbability_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.AddChild(decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node);
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(34);
			decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.AddChild(sequence3);
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node3 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node4 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node3();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node4.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node4.SetId(3);
			sequence3.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node4);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node4.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(10);
			sequence3.AddChild(sequence4);
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node26 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node5 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node26();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node5.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node5.SetId(26);
			sequence4.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node5);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node5.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node27 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node6 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node27();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node6.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node6.SetId(27);
			sequence4.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node6);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node6.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node28 action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node3 = new Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node28();
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node3.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node3.SetId(28);
			sequence4.AddChild(action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node3);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node3.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node18 action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node4 = new Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node18();
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node4.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node4.SetId(18);
			sequence4.AddChild(action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node4);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node4.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node0 action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node5 = new Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node0();
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node5.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node5.SetId(0);
			sequence4.AddChild(action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node5);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node5.HasEvents());
			sequence3.SetHasEvents(sequence3.HasEvents() | sequence4.HasEvents());
			decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetHasEvents(decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.HasEvents() | sequence3.HasEvents());
			selectorProbability_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetHasEvents(selectorProbability_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.HasEvents() | decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.HasEvents());
			DecoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node16 decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2 = new DecoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node16();
			decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.SetClassNameString("DecoratorWeight");
			decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.SetId(16);
			selectorProbability_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.AddChild(decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2);
			Selector selector = new Selector();
			selector.SetClassNameString("Selector");
			selector.SetId(37);
			decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.AddChild(selector);
			Sequence sequence5 = new Sequence();
			sequence5.SetClassNameString("Sequence");
			sequence5.SetId(49);
			selector.AddChild(sequence5);
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node13 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node7 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node13();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node7.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node7.SetId(13);
			sequence5.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node7);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node7.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node50 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node8 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node50();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node8.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node8.SetId(50);
			sequence5.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node8);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node8.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node51 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node9 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node51();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node9.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node9.SetId(51);
			sequence5.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node9);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node9.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node52 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node10 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node52();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node10.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node10.SetId(52);
			sequence5.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node10);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node10.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node53 action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node6 = new Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node53();
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node6.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node6.SetId(53);
			sequence5.AddChild(action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node6);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node6.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence5.HasEvents());
			Sequence sequence6 = new Sequence();
			sequence6.SetClassNameString("Sequence");
			sequence6.SetId(21);
			selector.AddChild(sequence6);
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node14 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node11 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node14();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node11.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node11.SetId(14);
			sequence6.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node11);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node11.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node22 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node12 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node22();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node12.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node12.SetId(22);
			sequence6.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node12);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node12.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node23 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node13 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node23();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node13.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node13.SetId(23);
			sequence6.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node13);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node13.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node24 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node14 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node24();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node14.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node14.SetId(24);
			sequence6.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node14);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node14.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node19 action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node7 = new Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node19();
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node7.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node7.SetId(19);
			sequence6.AddChild(action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node7);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node7.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence6.HasEvents());
			Sequence sequence7 = new Sequence();
			sequence7.SetClassNameString("Sequence");
			sequence7.SetId(56);
			selector.AddChild(sequence7);
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node15 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node15 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node15();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node15.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node15.SetId(15);
			sequence7.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node15);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node15.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node29 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node16 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node29();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node16.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node16.SetId(29);
			sequence7.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node16);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node16.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node30 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node17 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node30();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node17.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node17.SetId(30);
			sequence7.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node17);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node17.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node31 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node18 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node31();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node18.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node18.SetId(31);
			sequence7.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node18);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node18.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node32 action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node8 = new Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node32();
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node8.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node8.SetId(32);
			sequence7.AddChild(action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node8);
			sequence7.SetHasEvents(sequence7.HasEvents() | action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node8.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence7.HasEvents());
			Sequence sequence8 = new Sequence();
			sequence8.SetClassNameString("Sequence");
			sequence8.SetId(44);
			selector.AddChild(sequence8);
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node12 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node19 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node12();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node19.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node19.SetId(12);
			sequence8.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node19);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node19.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node45 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node20 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node45();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node20.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node20.SetId(45);
			sequence8.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node20);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node20.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node46 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node21 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node46();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node21.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node21.SetId(46);
			sequence8.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node21);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node21.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node47 condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node22 = new Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node47();
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node22.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node22.SetId(47);
			sequence8.AddChild(condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node22);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node22.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node48 action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node9 = new Action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node48();
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node9.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node9.SetId(48);
			sequence8.AddChild(action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node9);
			sequence8.SetHasEvents(sequence8.HasEvents() | action_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node9.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence8.HasEvents());
			decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.SetHasEvents(decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.HasEvents() | selector.HasEvents());
			selectorProbability_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetHasEvents(selectorProbability_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.HasEvents() | decoratorWeight_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node2.HasEvents());
			parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.SetHasEvents(parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.HasEvents() | selectorProbability_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | parallel_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node.HasEvents());
			return true;
		}
	}
}
