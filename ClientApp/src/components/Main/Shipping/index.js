/* eslint-disable max-len */
const shippingEstimateForm = ({ formCallback,
  estimateCallback,
  estimateVisibilityCallback }) => {
  async function handleShippingInput(event) {
    event.preventDefault()
    const data = {
      type: event.target.type.value,
      weight_unit: event.target.weight_unit.value,
      weight_value: event.target.weight_value.value,
      distance_unit: event.target.distance_unit.value,
      distance_value: event.target.distance_value.value,
      transport_method: event.target.transport_method.value,
    }
    console.log(data)
    await fetch(`http://localhost:5000/api/Attributes`, {
      method: `POST`,
      body: JSON.stringify(data),
      headers: {
        'Content-Type': `application/json`,
      },
    })
      .then(response => response.json())
      .then(data => estimateCallback(data))
      .then(data => console.log(data))

    formCallback(null)
    estimateVisibilityCallback(true)
  }

  const contentStyles = {
    maxWidth: `45vw`,
    margin: `auto`,
    marginTop: `30px`,
    padding: `10px`,
    justifyContent: `center`,
    alignItems: `center`,
    backgroundColor: `#0A090C`,
  }

  const inputStyles = {
    display: `block`,
    margin: `5px`,
  }

  return (
    <div style={contentStyles}>
      <div style={{
        backgroundColor: `#131217`,
        color: `#F5F5F5`,
        padding: `15px`,
        fontFamily: `'Montserrat', sans-serif`,
      }}
      >
        <p>
          It's only bad if you buy blueberries from Chile.
        </p>
        <form onSubmit={handleShippingInput}>
          <input type='hidden' name='type' value='shipping' />
          <div style={inputStyles}>
            <label htmlFor='weight_unit'>Unit of weight:
              <select name='weight_unit' style={{ margin: `0 0 0 10px` }}>
                <option value='lb'>Pounds (lb)</option>
                <option value='g'>Grams (g)</option>
                <option value='kg'>Kilograms (kg)</option>
                <option value='mt'>Metric tonnes (mt)</option>
              </select>
            </label>
          </div>
          <div style={inputStyles}>
            <label htmlFor='weight_value'>Total weight:
              <input
                type='number'
                step='0.1'
                min='0'
                name='weight_value'
                style={{ margin: `0 0 0 10px` }}
              />
            </label>
          </div>
          <div style={inputStyles}>
            <label htmlFor='distance_unit'>Unit of distance:
              <select name='distance_unit' style={{ margin: `0 0 0 10px` }}>
                <option value='mi'>Miles</option>
                <option value='km'>Kilometers</option>
              </select>
            </label>
          </div>
          <div style={inputStyles}>
            <label htmlFor='distance_value'>Distance shipped:
              <input
                type='number'
                step='0.1'
                min='0'
                name='distance_value'
                style={{ margin: `0 0 0 10px` }}
              />
            </label>
          </div>
          <div style={inputStyles}>
            <label htmlFor='transport_method'>Shipping method:
              <select name='transport_method' style={{ margin: `0 0 0 10px` }}>
                <option value='ship'>Ship</option>
                <option value='train'>Train</option>
                <option value='truck'>Truck</option>
                <option value='plane'>Plane</option>
              </select>
            </label>
          </div>
          <button type='submit' style={{ marginTop: `10px` }}>Estimate</button>
        </form>
      </div>
    </div>
  )
}

export default shippingEstimateForm
