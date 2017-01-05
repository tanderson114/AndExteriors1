namespace AndExteriors.Region1 {
    export class OrderDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Region1.OrderDetail';

    }

    export interface OrderDetailForm {
        ProductID: Serenity.LookupEditor;
        UnitPrice: Serenity.DecimalEditor;
        Quantity: Serenity.IntegerEditor;
        Discount: Serenity.DecimalEditor;
    }

    [['ProductID', () => Serenity.LookupEditor], ['UnitPrice', () => Serenity.DecimalEditor], ['Quantity', () => Serenity.IntegerEditor], ['Discount', () => Serenity.DecimalEditor]].forEach(x => Object.defineProperty(OrderDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

