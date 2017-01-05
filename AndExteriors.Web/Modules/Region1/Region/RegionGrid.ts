namespace AndExteriors.Region1 {

    @Serenity.Decorators.registerClass()
    export class RegionGrid extends Serenity.EntityGrid<RegionRow, any> {
        protected getColumnsKey() { return "Region1.Region"; }
        protected getDialogType() { return <any>RegionDialog; }
        protected getIdProperty() { return RegionRow.idProperty; }
        protected getLocalTextPrefix() { return RegionRow.localTextPrefix; }
        protected getService() { return RegionService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}