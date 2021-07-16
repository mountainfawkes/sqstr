const shippingEstimateForm = () => {
  function handleShippingInput(event) {
    event.preventDefault()
    return console.log({
      type: event.target.type.value,
      weight_unit: event.target.weight_unit.value,
      weight_value: event.target.weight_value.value,
      distance_unit: event.target.distance_unit.value,
      distance_value: event.target.distance_value.value,
      transport_method: event.target.transport_method.value,
    })
  }

  return (
    <>
      <h3>This is the Shipping form.</h3>
      <form onSubmit={handleShippingInput}>
        <input type='hidden' name='type' value='shipping' />
        <label htmlFor='weight_unit'>Unit of weight:
          <select name='weight_unit'>
            <option value='lb'>Pounds (lb)</option>
            <option value='g'>Grams (g)</option>
            <option value='kg'>Kilograms (kg)</option>
            <option value='mt'>Metric tonnes (mt)</option>
          </select>
        </label>
        <label htmlFor='weight_value'>Total weight:
          <input type='number' step='0.1' min='0' name='weight_value' />
        </label>
        <label htmlFor='distance_unit'>Unit of distance:
          <select name='distance_unit'>
            <option value='mi'>Miles</option>
            <option value='km'>Kilometers</option>
          </select>
        </label>
        <label htmlFor='distance_value'>Distance shipped:
          <input type='number' step='0.1' min='0' name='distance_value' />
        </label>
        <label htmlFor='transport_method'>Shipping method:
          <select name='transport_method'>
            <option value='ship'>Ship</option>
            <option value='train'>Train</option>
            <option value='pruck'>Truck</option>
            <option value='plane'>Plane</option>
          </select>
        </label>
        <button type='submit'>Estimate</button>
      </form>
    </>
  )
}

export default shippingEstimateForm
