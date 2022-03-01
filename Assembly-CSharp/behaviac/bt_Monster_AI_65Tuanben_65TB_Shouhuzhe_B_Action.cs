﻿using System;

namespace behaviac
{
	// Token: 0x02002C64 RID: 11364
	public static class bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action
	{
		// Token: 0x060141C3 RID: 82371 RVA: 0x00609EBC File Offset: 0x006082BC
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/65Tuanben/65TB_Shouhuzhe_B_Action");
			bt.IsFSM = false;
			Selector selector = new Selector();
			selector.SetClassNameString("Selector");
			selector.SetId(22);
			bt.AddChild(selector);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(3);
			selector.AddChild(sequence);
			Condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node7 condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node = new Condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node7();
			condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.SetId(7);
			sequence.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.HasEvents());
			SelectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node9 selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node = new SelectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node9();
			selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.SetClassNameString("SelectorProbability");
			selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.SetId(9);
			selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.Initialize("Self.BTAgent::Action_GenRandom()");
			sequence.AddChild(selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node);
			DecoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node16 decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node = new DecoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node16();
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.SetClassNameString("DecoratorWeight");
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.SetId(16);
			selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.AddChild(decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node);
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(10);
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.AddChild(sequence2);
			Condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2 condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2 = new Condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2();
			condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.SetId(2);
			sequence2.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node0 action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node = new Action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node0();
			action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.SetId(0);
			sequence2.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.HasEvents());
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.SetHasEvents(decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.HasEvents() | sequence2.HasEvents());
			selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.SetHasEvents(selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.HasEvents() | decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.HasEvents());
			DecoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node19 decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2 = new DecoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node19();
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.SetClassNameString("DecoratorWeight");
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.SetId(19);
			selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.AddChild(decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2);
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(12);
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.AddChild(sequence3);
			Condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4 condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3 = new Condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4();
			condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3.SetId(4);
			sequence3.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node1 action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2 = new Action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node1();
			action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.SetId(1);
			sequence3.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.HasEvents());
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.SetHasEvents(decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.HasEvents() | sequence3.HasEvents());
			selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.SetHasEvents(selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.HasEvents() | decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.HasEvents());
			sequence.SetHasEvents(sequence.HasEvents() | selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(5);
			selector.AddChild(sequence4);
			Condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node6 condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4 = new Condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node6();
			condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4.SetId(6);
			sequence4.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4.HasEvents());
			SelectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node8 selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2 = new SelectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node8();
			selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.SetClassNameString("SelectorProbability");
			selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.SetId(8);
			selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.Initialize("Self.BTAgent::Action_GenRandom()");
			sequence4.AddChild(selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2);
			DecoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node11 decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3 = new DecoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node11();
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3.SetClassNameString("DecoratorWeight");
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3.SetId(11);
			selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.AddChild(decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3);
			Sequence sequence5 = new Sequence();
			sequence5.SetClassNameString("Sequence");
			sequence5.SetId(13);
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3.AddChild(sequence5);
			Condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node14 condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node5 = new Condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node14();
			condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node5.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node5.SetId(14);
			sequence5.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node5);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node5.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node15 action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3 = new Action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node15();
			action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3.SetId(15);
			sequence5.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3.HasEvents());
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3.SetHasEvents(decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3.HasEvents() | sequence5.HasEvents());
			selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.SetHasEvents(selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.HasEvents() | decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node3.HasEvents());
			DecoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node17 decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4 = new DecoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node17();
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4.SetClassNameString("DecoratorWeight");
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4.SetId(17);
			selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.AddChild(decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4);
			Sequence sequence6 = new Sequence();
			sequence6.SetClassNameString("Sequence");
			sequence6.SetId(18);
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4.AddChild(sequence6);
			Condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node20 condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node6 = new Condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node20();
			condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node6.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node6.SetId(20);
			sequence6.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node6);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node6.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node21 action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4 = new Action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node21();
			action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4.SetId(21);
			sequence6.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4.HasEvents());
			decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4.SetHasEvents(decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4.HasEvents() | sequence6.HasEvents());
			selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.SetHasEvents(selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.HasEvents() | decoratorWeight_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node4.HasEvents());
			sequence4.SetHasEvents(sequence4.HasEvents() | selectorProbability_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Action_node2.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence4.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | selector.HasEvents());
			return true;
		}
	}
}
