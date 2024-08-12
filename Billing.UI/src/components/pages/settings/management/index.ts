import Bouer, { Component } from "bouerjs";

import ManagementMenu from "../widgets/management-menu";
import CategoryComponent from "./category/list";
import html from './management.html';
import SubCategoryComponent from "./subcategory/list";
import PaymentMethodComponent from "./paymentmethods/list";

export default class ManagementComponent extends Component {
    readonly title = 'Management';
    readonly route = '/management';
    readonly bouer = this.bouer! as Bouer;

    data = {
        active: 'management',
    };

    children = [
		ManagementMenu,
        
        CategoryComponent,
        SubCategoryComponent,
        PaymentMethodComponent
    ];

    constructor() {
        super(html);
    }
}